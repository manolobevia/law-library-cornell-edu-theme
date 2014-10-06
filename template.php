<?php

/**
 * @file
 * template.php
 */

function law_library_bootstrap_js_alter(&$js)
{
    // Override bootstrap.js to fix bug:
    //  https://drupal.org/node/2162165
    if (isset($js['sites/all/themes/bootstrap/js/bootstrap.js'])) {
        $theme_path = drupal_get_path('theme', 'law_library_bootstrap');
        $js['sites/all/themes/bootstrap/js/bootstrap.js']['data'] = $theme_path . '/js/bootstrap.js';
    }
}