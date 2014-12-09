<?php

/**
 * @file
 * template.php
 */

/**
 * Theme function for 'cul_hours_field_hours_id'  field formatter.
 */
function law_library_bootstrap_cul_hours_formatter_cul_hours_field_hours_id($element) {
  if (isset($element['element']['safe_value'])) {
    $id = $element['element']['safe_value'];
    return cul_hours_dailyHoursFromId($id);
  }
}

function law_library_bootstrap_cul_hours_dailyHoursFromId($id) {
  global $abbrev_map;
  $lib_name = array_search($id, $abbrev_map);
  $id = urlencode($id);
  $output = 'unknown result';

  # Hacks for 'static' library hours
  if ($id == 'Engineering') {
    $output = "24/7 study space and computing only";
  }
  elseif ($id == 'PhysSci') {
   $output = "24/7 quiet study space only";
  }
  # We really don't want to be doing a lot of calculations in a view, so use the cache
  elseif (($cache = cache_get('daily_hours_'.$id) !== FALSE) && !empty($cache->data)) {
   $output = $cache->data;
  }
  else {
    $cache_expire_minutes = 5;

    # Grab the output from the today's hours service
    $url = "http://mannservices.mannlib.cornell.edu/LibServices/showLibraryHoursToday.do?location=$id&output=json";
    $result = json_decode(file_get_contents($url));

    # override determines whether the library is open all day (1), closed all day (2),
    # or has both open and closing times (0).
    if ($result && $result->override == 1) {
      $output = "<span>Today:</span> Open all day";
      $output .= '   <span class="label label-success library-open">Open</span>';
    }
    elseif ($result && $result->override ==2) {
      $output = "<span>Today:</span> Closed all day";
      $output .= '   <span class="label label-danger library-closed">Closed</span>';
    }
    elseif ($result) {
      $script_tz = date_default_timezone_get();
      date_default_timezone_set('UTC');
      $UTC_now = time();
      date_default_timezone_set('America/New_York'); //show hours in Ithaca time
      $ITHACA_now = time();
      $offset = variable_get('cul_hours_time_offset', 0);

      // if debugging (offset not 0) set cache to expire asap
      $cache_expire_minutes = ($offset == 0) ? 5 : 1;
      if ($offset != 0) {
        $ITHACA_now += ($offset * 60 * 60);
      }

      $output = '<span>Today:</span> ';
      $open_now = ( _cul_hours_isopen($lib_name) === 1 ); // Whether library is currently open
      # Check whether the library is starting open but closing during the day
      if ($result->startTime == null && $result->endTime != null) {
        $end  = date("g:i a", $result->endTime);
        $output .= "Closes at $end";
        //$open_now = ($UTC_now < $result->endTime);
      }
      # Check whether the library is starting closed but ending the day open
      elseif ($result->endTime == null && $result->startTime != null) {
        $start = date("g:i a", $result->startTime);
        $output .= "Opens at $start";
        //$open_now = ($UTC_now >= $result->startTime);
      }
      # Else normal business
      else {
        $start = date("g:i a", $result->startTime);
        $end  = date("g:i a", $result->endTime);
        $output .= "$start - $end";
        //$open_now = ($UTC_now >= $result->startTime && $UTC_now < $result->endTime);

        //debugging code:
        $details = array(
          "@id" => $id,
          "@start" => $start,
          "@end" => $end,
          "@output" => $output,
          "@currentTime" => $ITHACA_now,
          "@open_now" => $open_now,
          );
        watchdog('cul_hours', '@id: Start @start; End @end; Output @output; Timestamp @userTimestamp; Time @currentTime; Open? @open_now', $details, WATCHDOG_NOTICE, 'link');
        //...debugging code
      }

      if ($open_now === TRUE) {
        $output .= '   <span class="label label-success library-open">Open!</span>';
      }
      else {
        $output .= '   <span class="label label-danger library-closed">Closed</span>';
      }

      date_default_timezone_set($script_tz);
    }

    // cache expires after $cache_expire_minutes min
    $cache_time = "+$cache_expire_minutes minutes";
    $expire = strtotime($cache_time, time());
    cache_set('daily_hours_' . $id, $output, 'cache', $expire);
  }
  return $output;
}