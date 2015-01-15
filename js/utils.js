
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

                $('.cul-branding').css('z-index', 9997);

                searchHide = true;
                console.log(searchHide)

              }


                
            });

    /////////////////////////////
    // Home search filter
    // Toggle filter select list


     var $searchFilterList = $('#filter-search-nav');
     var $isFilterOpen = false;

     $('div.filter-search').click(function(e) {
         e.preventDefault();

         if (!$isFilterOpen) {

             //Change button filter state to selected
             
             $(this).find('span').removeClass('filter-default');
             $(this).find('span').addClass('filter-active');

             //Reveal filter select list
             $searchFilterList.css('display','block');

             $isFilterOpen = true;

         } else {
             //Change button filter state to default
             
             $(this).find('span').removeClass('filter-active');
             $(this).find('span').addClass('filter-default');

             //Hide filter select list
             $searchFilterList.css('display','none');

             $isFilterOpen = false;

         }
    });

     //
     //
     // Collect users' selection
     //
     // 
        var $selectedFilter = "Library Catalog";

       $('#filter-search-nav li').each(function(index){
           $(this).click(function(ev){
              
              ev.preventDefault();

              //console.log($(this).text());
              //Selected filter feedback
              $('.search-filter-selected').text($(this).text()).fadeIn('slow');
              $('input[name="classgroup"]').val('');

              $('.filter-search .active').text($(this).text());

              //$selectedFilter = $(this).text();

              //console.log($(this).parent());

               //Hide filter select list
               //$searchFilterList.css('display','none');

               //console.log($searchFilterList);

               //Change button filter state to default
               //$('a.filter-search').css('background','url(../../themes/vivo-cornell/images/filteredSearch.gif) no-repeat right top');
               $('a.filter-search').removeClass('filter-active');
               $('a.filter-search').addClass('filter-default');

               
               $isFilterOpen = false;


           });

       });


        

       //When focus, hide filter select list and change filter button state to default
       $('input.search-homepage').focus(function(){

           $('input.search-homepage').attr("value","");
           $('input.search-homepage').css({
               'text-align' : 'left',
               'opacity' : 1
           });

           if (!$isFilterOpen) {

               $isFilterOpen = false;

           }else {

                //Hide filter select list
                    $('#filter-search-nav').hide();

                    //Change button filter state to default
                    //$('a.filter-search').css('background','url(../../themes/vivo-cornell/images/filteredSearch.gif) no-repeat right top');
                    $('div.filter-search').find('span').removeClass('filter-active');
                    $('div.filter-search').find('span').addClass('filter-default');

                    $isFilterOpen = false;

             }

       });

       


       $( '#search' ).submit(function(ev) {
          
          var send = $('.search-homepage').val() + '    ' + $selectedFilter;
          console.log(send);

          switch ($selectedFilter) {

                case 'Library Catalog':
                    $(this).attr("action", 'https://search.library.cornell.edu');
                    break;

                case 'WorldCat':
                    $(this).attr("action", 'http://cornell.worldcat.org/search?qt=wc_org_cornell');
                    break;

                case 'Activities':

                    $(this).attr("method", 'get');
                    $('#edit_keys').name = "keys";
                    $(this).attr("action", '/search/node/');
                    break;
            }



          //$(this).attr("action", 'https://search.library.cornell.edu');

        });

    


});



