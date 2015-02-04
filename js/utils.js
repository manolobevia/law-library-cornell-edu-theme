
$(document).ready(function () {

    //hide container nav

    //$('#nav li ul').hide();
    
    $('#myCarousel').carousel('pause');


    // Init megamenu for touch devices
    //$( '#nav li:has(ul)' ).doubleTapToGo();
    $( '#nav li:has(.wrapper)' ).doubleTapToGo();

    $('.sandwich').click(function(e){

        e.preventDefault();
        $(' #nav ').toggle();

      });

        
        var $owl = $('.owl-carousel');


        $owl.owlCarousel({

            loop: true,
            margin: 30,
            nav: false,
            responsive:{
                0:{
                    items:1
                },
                450:{
                    items:2
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
            //var $culBranding = $('.cul-branding .cu-logo');
            var $culBranding = $('.cul-branding');
            //var $userTools = $('.cul-branding .user-tools');
            var $sandwich = $('.sandwich');
  


              $('.show-hide-search').click(function(){

              if (searchHide) {

                    $slider.show();
                    $culBranding.hide();
                    $sandwich.hide()
                    
                    $('.close-search').show();
                    searchHide = false;
                }
              });


              $('.close-search').click(function(e){

                e.preventDefault();
                $slider.hide();
                $culBranding.show();
                $sandwich.show()

                $('.close-search').hide();
                searchHide = true;
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
             
             //$(this).find('span').removeClass('glyphicon-chevron-down');
             //$(this).find('span').addClass('glyphicon-chevron-up');

             //Reveal filter select list
             $searchFilterList.css('display','block');

             $isFilterOpen = true;

         } else {
             //Change button filter state to default
             
             //$(this).find('span').removeClass('glyphicon-chevron-up');
             //$(this).find('span').addClass('glyphicon-chevron-down');

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

              $selectedFilter = $(this).text();

              //console.log($(this).parent());

               //Hide filter select list
               //$searchFilterList.css('display','none');

               //console.log($searchFilterList);

               //Change button filter state to default
               //$('a.filter-search').css('background','url(../../themes/vivo-cornell/images/filteredSearch.gif) no-repeat right top');
               //$('a.filter-search').removeClass('glyphicon-chevron-up');
               //$('a.filter-search').addClass('glyphicon-chevron-down');

               
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
                    //$('div.filter-search').find('span').removeClass('glyphicon-chevron-up');
                    //$('div.filter-search').find('span').addClass('glyphicon-chevron-down');

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
                    $(this).attr("action", 'https://cornell.worldcat.org/search?qt=wc_org_cornell');
                    break;

                case 'Site Search':

                    $(this).attr("method", 'get');
                    $('input.search-homepage').attr("name",'keys');
                    $(this).attr("action", '/search/node/');
                    break;
            }



          //$(this).attr("action", 'https://search.library.cornell.edu');

        });

      
      //Add active class to parent link in megamenus

      var loc = window.location.href; // returns the full URL
      
      if(/about/.test(loc)) {
        $('#about').addClass('active');
      }

      if(/usingthelibrary/.test(loc)) {
        $('#usingthelibrary').addClass('active');
      }

      if(/research/.test(loc)) {
        $('#research').addClass('active');
      }

      if(/facultyservices/.test(loc)) {
        $('#facultyservices').addClass('active');
      }

      if(/specialcollections/.test(loc)) {
        $('#specialcollections').addClass('active');
      }

      if('/'.test(loc)) {
        $('#home').addClass('active');
      }

});



