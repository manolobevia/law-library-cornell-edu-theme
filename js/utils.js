
$(document).ready(function () {

    /*$('.rs-carousel').carousel({
        pagination: false,
        itemsPerTransition:3,
        insertPrevAction: function () {
        return $('<a href="#" class="rs-carousel-action-prev"><</a>').appendTo($(this).find('.carousel-prev'));
        },
        insertNextAction: function () {
        return $('<a href="#" class="rs-carousel-action-next">></a>').appendTo($(this).find('.carousel-next'));
        }
        
    });

    // Make carousel responsive
    $(window).resize(function () {
        $('.rs-carousel').carousel('refresh');
    });*/

    $('#myCarousel').carousel('pause');


    /*$('#slideshow').carousel({
      interval: 5000
    });*/)


});




    /*<script>

    http://jockstothecore.com/proper-implementation-of-background-images-with-text-inside-responsive-carousels/
      !function ($) {
        $(function(){
          // carousel demo
          $('#myCarousel').carousel()
        })
      }(window.jQuery)
    </script>
    */


/*

REFERENCE
$('.rs-carousel').carousel({
    itemsPerTransition:1,
    pagination:false,
    insertPrevAction: function () {
      return $('<a href="#" class="rs-carousel-action-prev"></a>').appendTo($(this).closest('.carousel-container').find('.carousel-prev'));
    },
    insertNextAction: function () {
      return $('<a href="#" class="rs-carousel-action-next"></a>').appendTo($(this).closest('.carousel-container').find('.carousel-next'));
    }
  }).show(400, function() {
    var $rsCarousel = $(this);

    // Show the paging controls if they are needed
    if ($rsCarousel.carousel('getNoOfPages') > 1) {   
      $rsCarousel.closest('.carousel-container').find('.paging-link').show();
    }
  });
  
  $('.carousel-prompt').click(function() {
    $(this).next('.proposal-topics').fadeOut('slow').fadeIn('slow');
  });

  // Make carousel responsive
  $(window).resize(function () {
    $('.rs-carousel').carousel('refresh');
  });




  insertPrevAction: function () { return $('<a href="#" class="rs-carousel-action rs-carousel-action-prev"><</a>').appendTo(this); },
        insertNextAction: function () { return $('<a href="#" class="rs-carousel-action rs-carousel-action-next">></a>').appendTo(this); }


*/
