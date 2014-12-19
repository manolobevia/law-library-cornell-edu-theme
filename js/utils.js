
$(document).ready(function () {

   
    
    $('#myCarousel').carousel('pause');



    $( '#nav li:has(ul)' ).doubleTapToGo();

        
        var $owl = $('.owl-carousel');


        $owl.owlCarousel({

            loop: true,
            margin: 15,
            nav: false,
            responsive:{
                0:{
                    items:1
                },
                600:{
                    items:3
                },
                1000:{
                    items:5
                }
            }
        })


        // Go to the next item
            $('.customNextBtn').click(function() {
                $owl.trigger('next.owl.carousel');
            })
            // Go to the previous item
            $('.customPrevBtn').click(function() {
                // With optional speed parameter
                // Parameters has to be in square bracket '[]'
                $owl.trigger('prev.owl.carousel', [300]);
            })


          // show/hide search on interior pages
            //search-slider
            //show-hide-search

            $(".search-slider").hide();
            //$(".show-hide-search").show();
            
            var searchHide = true;
            var $slider = $(".search-slider");
            var $culBranding = $('.cul-branding .cu-logo');
            var $userTools = $('.cul-branding .user-tools');

            $('.show-hide-search').click(function(){

              if (searchHide) {

                $slider.show();
                $culBranding.hide();

                $userTools.find('.hours-icon').css('opacity', 0);
                $userTools.find('.reservations-icon').css('opacity', 0);
                
                $(this).find('span').removeClass('glyphicon-search').addClass('glyphicon-remove');

                $('.cul-branding').css('z-index', 99999);

                searchHide = false;
                console.log(searchHide)
              }

              else {

                $slider.hide();
                $culBranding.show();
                $userTools.find('.hours-icon').css('opacity', 1);
                $userTools.find('.reservations-icon').css('opacity', 1);

                $(this).find('span').removeClass('glyphicon-remove').addClass('glyphicon-search');

                searchHide = true;
                console.log(searchHide)

              }


                
            });


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
