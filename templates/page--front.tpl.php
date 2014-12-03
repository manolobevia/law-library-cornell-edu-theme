 <?php
/**
 * @file
 * Default theme implementation to display a single Drupal page.
 *
 * The doctype, html, head and body tags are not in this template. Instead they
 * can be found in the html.tpl.php template in this directory.
 *
 * Available variables:
 *
 * General utility variables:
 * - $base_path: The base URL path of the Drupal installation. At the very
 *   least, this will always default to /.
 * - $directory: The directory the template is located in, e.g. modules/system
 *   or themes/bartik.
 * - $is_front: TRUE if the current page is the front page.
 * - $logged_in: TRUE if the user is registered and signed in.
 * - $is_admin: TRUE if the user has permission to access administration pages.
 *
 * Site identity:
 * - $front_page: The URL of the front page. Use this instead of $base_path,
 *   when linking to the front page. This includes the language domain or
 *   prefix.
 * - $logo: The path to the logo image, as defined in theme configuration.
 * - $site_name: The name of the site, empty when display has been disabled
 *   in theme settings.
 * - $site_slogan: The slogan of the site, empty when display has been disabled
 *   in theme settings.
 *
 * Navigation:
 * - $main_menu (array): An array containing the Main menu links for the
 *   site, if they have been configured.
 * - $secondary_menu (array): An array containing the Secondary menu links for
 *   the site, if they have been configured.
 * - $breadcrumb: The breadcrumb trail for the current page.
 *
 * Page content (in order of occurrence in the default page.tpl.php):
 * - $title_prefix (array): An array containing additional output populated by
 *   modules, intended to be displayed in front of the main title tag that
 *   appears in the template.
 * - $title: The page title, for use in the actual HTML content.
 * - $title_suffix (array): An array containing additional output populated by
 *   modules, intended to be displayed after the main title tag that appears in
 *   the template.
 * - $messages: HTML for status and error messages. Should be displayed
 *   prominently.
 * - $tabs (array): Tabs linking to any sub-pages beneath the current page
 *   (e.g., the view and edit tabs when displaying a node).
 * - $action_links (array): Actions local to the page, such as 'Add menu' on the
 *   menu administration interface.
 * - $feed_icons: A string of all feed icons for the current page.
 * - $node: The node object, if there is an automatically-loaded node
 *   associated with the page, and the node ID is the second argument
 *   in the page's path (e.g. node/12345 and node/12345/revisions, but not
 *   comment/reply/12345).
 *
 * Regions:
 * - $page['help']: Dynamic help text, mostly for admin pages.
 * - $page['highlighted']: Items for the highlighted content region.
 * - $page['content']: The main content of the current page.
 * - $page['sidebar_first']: Items for the first sidebar.
 * - $page['sidebar_second']: Items for the second sidebar.
 * - $page['header']: Items for the header region.
 * - $page['footer']: Items for the footer region.
 *
 * @see bootstrap_preprocess_page()
 * @see template_preprocess()
 * @see template_preprocess_page()
 * @see bootstrap_process_page()
 * @see template_process()
 * @see html.tpl.php
 *
 * @ingroup themeable
 */
?>

<?php
$theme_path = base_path() . 'sites/all/themes/law_library_bootstrap/';
?>


        



<!-- CUL BRANDING -->
        <section class="cul-branding">
                <img class="cu-logo" src="<?php print $theme_path; ?>images/cul-branding/cu-logo.png" />
        </section>

        





        <!-- HERO CAROUSEL-->

        <section class="hero">

            <div id="myCarousel" class="carousel slide carousel-fade">


                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>

                <div class="carousel-inner">

                    <!-- slide #1 -->

                    <div class="item active" style="background: url('<?php print $theme_path; ?>images/carousel-home/carousel-image-1.jpg') no-repeat left center; background-size: cover;">

                        <div class="container">

                            


                            <div class="carousel-caption">
                                <h1>Scribentur eloquentiam cu eos.</h1>
                                <p class="lead">Putant evertitur te sed, eos cu habemus perfecto. Id vix nemore dolorem constituto. Ei labore erroribus persecuti vis. Quodsi elaboraret definitionem eos ei.</p>

                            </div>


                        </div>

                    </div>

                     <!-- slide #2 -->

                    <div class="item" style="background: url('<?php print $theme_path; ?>images/carousel-home/carousel-image-2.jpg') no-repeat left center; background-size: cover;">

                        <div class="container">

                            


                            <div class="carousel-caption">
                                <h1>Scribentur eloquentiam cu eos.</h1>
                                <p class="lead">Putant evertitur te sed, eos cu habemus perfecto. Id vix nemore dolorem constituto. Ei labore erroribus persecuti vis. Quodsi elaboraret definitionem eos ei.</p>

                            </div>


                        </div>

                    </div>


                    <!-- slide #3 -->

                    <div class="item" style="background: url('<?php print $theme_path; ?>images/carousel-home/carousel-image-3.jpg') no-repeat left center; background-size: cover;">

                        <div class="container">

                            


                            <div class="carousel-caption">
                                <h1>Scribentur eloquentiam cu eos.</h1>
                                <p class="lead">Putant evertitur te sed, eos cu habemus perfecto. Id vix nemore dolorem constituto. Ei labore erroribus persecuti vis. Quodsi elaboraret definitionem eos ei.</p>

                            </div>


                        </div>

                    </div>


                    
                    <div class="item" style="background: url('<?php print $theme_path; ?>images/carousel-home/carousel-image-1.jpg') no-repeat left center; background-size: cover;">

                        <div class="container">


                            <!--<div class="carousel-caption">
                                <h1>Example headline.</h1>
                                <p class="lead">Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget.</p>
                                <a class="btn btn-large btn-primary" href="#">Sign up today</a>
                            </div>-->


                        </div>

                    </div>


                </div>


                <!--<a class="left carousel-control" href="#myCarousel" data-slide="prev">&lsaquo;</a>
                <a class="right carousel-control" href="#myCarousel" data-slide="next">&rsaquo;</a>-->

            </div><!-- /.carousel -->

        </section>

        <!-- LAW BRANDING + MAIN NAVIGATION-->

        <header class="main-nav">

            <h1>
                <a href="/"><img class="law-logo" src="<?php print $theme_path; ?>images/law-logo.png" /></a>
            </h1>

        </header>





        <!-- MAIN NABIGATION / MEGAMENUS -->


        <nav id="nav" role="navigation">
            <a class="sandwich" href="#nav" title="Show navigation">Show navigation</a>
            <a class="sandwich" href="#" title="Hide navigation">Hide navigation</a>

            <ul class="clearfix">

                <!-- HOME -->

                <li class="first"><a class="active" href="index.html">HOME</a></li>

                <!-- ABOUT -->

                <li>
                    <a href="#" title="">ABOUT</a>

                    <ul class="container-nav">
                        <div class="row">
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Hours</a>
                                        <a href="#">Location</a>
                                        <a href="#">Mission and Vision</a>
                                        <a href="#">History</a>
                                            
                                            <a class="sub-sub-items" href="#">Law Library History</a>
                                            <a class="sub-sub-items" href="#">Law School Chronology</a>
                                            <a class="sub-sub-items" href="#">Buildings and Notable People</a>
                                            
                                    </div>
                                </li>
                            </div>

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Policies</a>

                                            <a class="sub-sub-items" href="#">Circulation</a>
                                            <a class="sub-sub-items" href="#">Study Rooms / Room Reservations Carrels</a>
                                            <a class="sub-sub-items" href="#">Photography and Videography After-Hours Access</a>
                                            <a class="sub-sub-items" href="#">Food & Drink</a>
                                            <a class="sub-sub-items" href="#">Borrowing & Lending</a>
                                            <a class="sub-sub-items" href="#">Collection Development</a>
                                    </div>
                                </li>
                            </div>
                            
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Law Library Space</a>
                                            <a class="sub-sub-items" href="#">Law Library Map</a>
                                            <a class="sub-sub-items" href="#">Study Areas</a>
                                            <a class="sub-sub-items" href="#">Reading Room</a>

                                        <a href="#">Our Partners</a>
                                            <a class="sub-sub-items" href="#">Eliminate completely?</a>

                                        <a href="#">Law Library Annual Report</a>
                                            <a class="sub-sub-items" href="#">Current</a>
                                            <a class="sub-sub-items" href="#">Archives</a>
                                    </div>
                                </li>
                            </div>


                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Law Library Space</a>
                                            <a class="sub-sub-items" href="#">Law Library Map</a>
                                            <a class="sub-sub-items" href="#">Study Areas</a>
                                            <a class="sub-sub-items" href="#">Reading Room</a>

                                        <a href="#">Our Partners</a>
                                            <a class="sub-sub-items" href="#">Eliminate completely?</a>

                                        <a href="#">Law Library Annual Report</a>
                                            <a class="sub-sub-items" href="#">Current</a>
                                            <a class="sub-sub-items" href="#">Archives</a>
                                    </div>
                                </li>
                            </div>



                        </div>
                    </ul>   
                </li>

                <!-- USING THE LIBRARY -->

                <li>
                    <a href="#" title="">USING THE LIBRARY</a>

                    <ul class="container-nav">
                        <div class="row">
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Navigation & Access</a>


                                            <a class="sub-sub-items" href="#">On the Shelf</a>
                                            <a class="sub-sub-items" href="#">Electronic</a>
                                            <a class="sub-sub-items" href="#">Library-to-Library How To</a>
                                            <a class="sub-sub-items" href="#">Library Annex How To</a>
                                            <a class="sub-sub-items" href="#">lorem, ipsum, sit, amet</a>
                                            <a class="sub-sub-items" href="#">Document Delivery How To</a>
                                            <a class="sub-sub-items" href="#">Borrow Direct How To</a>
                                            <a class="sub-sub-items" href="#">ILL How To</a>
                                            <a class="sub-sub-items" href="#">Recall How To</a>
                                            
                                    </div>
                                </li>
                            </div>

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Recreation at the Library</a>

                                            <a class="sub-sub-items" href="#">Programming</a>
                                            <a class="sub-sub-items" href="#">Recreational Collections</a>

                                        <a href="#">Library Policies</a>

                                            <a class="sub-sub-items" href="#">Food & Drink Policy</a>
                                            <a class="sub-sub-items" href="#">Borrowing & Lending Policies ⁃ Carrel Policy</a>
                                            <a class="sub-sub-items" href="#">Room Reservation Policy</a>
                                            <a class="sub-sub-items" href="#">After Hours (sticker) Policy</a>
                                    </div>
                                </li>
                            </div>
                            
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#"> Faculty Services</a>
                                            <a class="sub-sub-items" href="#">Law Library Map</a>
                                                <a class="sub-sub-items" href="#">Put an item on course reserve</a>
                                                <a class="sub-sub-items" href="#">Set up a proxy</a>
                                                <a class="sub-sub-items" href="#">Routing services</a>
                                                <a class="sub-sub-items" href="#">Find Your Faculty Liaison</a>
                                                <a class="sub-sub-items" href="#">Increase your audience & impact</a>
                                                <a class="sub-sub-items" href="#">Request help setting up selected works page</a>
                                                <a class="sub-sub-items" href="#">Request an item not in collection</a>
                                                <a class="sub-sub-items" href="#">Request a supporting collection for a faculty publication</a>
                                                <a class="sub-sub-items" href="#">Faculty Publications Report</a>
                                    
                                    </div>
                                </li>
                            </div>

                            
            
                        </div>
                    </ul>   
                </li>


                <!-- RESEARCH -->

                <li>
                    <a href="#" title="">RESEARCH</a>

                    <ul class="container-nav">
                        <div class="row">
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Databases</a>
                                        <a href="#">Catalogs</a>
                                        <a href="#">Online Legal Resources</a>
                                            <a class="sub-sub-items" href="#">InSIte</a>
                                        <a href="#">Research Help</a>
                                            <a class="sub-sub-items" href="#">Research Consults</a>
                                            <a class="sub-sub-items" href="#">Research Desk Info</a>
                                            <a class="sub-sub-items" href="#">Chat Reference</a>
                                            <a class="sub-sub-items" href="#">Classroom Support</a>
                                        <a href="#">Research Prize Info</a>
                                            
                                    </div>
                                </li>
                            </div>

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Cross-Links to Collections</a>
                                        


                                            <a class="sub-sub-items" href="#">Special</a>
                                            <a class="sub-sub-items" href="#">Microform</a>
                                            <a class="sub-sub-items" href="#">Gov Docs</a>
                                            <a class="sub-sub-items" href="#">Foreign/Int'l</a>
                                            
                                        <a href="#"> Legal Research Engine</a>
                                    </div>
                                </li>
                            </div>

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Lorem Ipsum</a>

                                            <img src="" style="width: 250px;height: 250px; background-color: gray">
                                            
                                        <a href="#"> Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a>
                                            
                                    </div>
                                </li>
                            </div>
                            
            
                        </div>
                    </ul>   
                </li>

                <!-- EXPLORE -->

                <li>
                    <a href="#" title="">EXPLORE</a>
                </li>


                <!-- OTHER COLLECTIONS -->

                <li>
                    <a href="#" title="">SPECIAL COLLECTIONS</a>

                    <ul class="container-nav">
                        <div class="row">
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <img src="" style="width: 250px;height: 250px; background-color: gray">
                                    </div>
                                </li>
                            </div>

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <img src="" style="width: 250px;height: 250px; background-color: gray">
                                    </div>
                                </li>
                            </div>
                            

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <img src="" style="width: 250px;height: 250px; background-color: gray">
                                    </div>
                                </li>
                            </div>
                            

                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <img src="" style="width: 250px;height: 250px; background-color: gray">
                                    </div>
                                </li>
                            </div>
                            
                            
                        </div>
                    </ul>   
                </li>


                <!-- ANOTHER -->

                <li>
                    <a href="#" title="">ANOTHER LINK</a>

                    <ul class="container-nav">
                        <div class="row">
                            <div class="cell">
                                <li>
                                    <div class="sub-items">
                                        <a href="#">Lorem navigatus</a>


                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            <a class="sub-sub-items" href="#">Ipsum Lorem Relecta</a>
                                            
                                    </div>
                                </li>
                            </div>
                            
            
                        </div>
                    </ul>   
                </li>



            </ul>
        </nav>

        <section class="search-home">

            <form id="form1" name="form1" method="get" action="/">
                <label for="name">Search</label>
                <div class="filtered-search">

                    <input type="text" class="form-text" name="q" value="" />
                    <select name="search_type" id="search_type" size="1" onChange="chgAction()" class="form-control filter">
                      <option value="law" selected="selected">Law Collections</option>
                      <option value="catalog">Library Catalog</option>
                      <option value="worldcat">WorldCat</option>
                      </select>
                    <input type="hidden" name="f[lc_1letter_facet][]" id ="callno" value ="">
                    <input type="hidden" name="search_field" value="all_fields">


                    <!--a class="filter" href="#">LAW LIBRARY <span class="caret-icon">></span></a> -->
                    <button type="submit" class="submit-search" href="#"><span class="glyphicon glyphicon-search"></span></button>
                </div>
            </form>         
            
            <ul class="external-search">
                <li><a href="#">Books in other libraries</a> / </li>
                <li><a href="#">Databases</a> / </li>
                <li><a href="#">Research Guides</a></li>
            </ul>

        </section>


        <section class="reservation-hours">

        </section>



        <div class="nav">
            <?php print render($page['navigation']); ?>
        </div>
        

                        
        <section class="media">

            <div class="owl-carousel media-items">
                
                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>
                
                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>

                <!--Media item-->
                <div class="item">
      
                    <figure>
                        <a href="#"><img class="image-media" src="<?php print $theme_path; ?>images/carousel-media/media-item-1.jpg" />
                        <img class="mask-media" src="<?php print $theme_path; ?>images/carousel-media/mask-media.png" /></a>

                        <figcaption>
                            Law Library will host Cornell Companions, a pet visitation program
                        </figcaption>                    
                    </figure>

                </div>


            </div>

            <div class="customNavigation">
                <a class="btn prev">Previous</a>
                <a class="btn next">Next</a>
                <a class="btn play">Autoplay</a>
                <a class="btn stop">Stop</a>
            </div>
        </section>

    
        <footer class="row">
              <?php print render($page['footer']); ?>
        </footer>
<script>

function chgAction() {
    var form = document.form1;
    
    console.log('chgAction()');
    console.log(form.search_type.selectedIndex);
    
    switch (form.search_type.selectedIndex) {
        case 1:
            form.action = "http://newcatalog.library.cornell.edu/";
            form.callno.value = "K - Law"
            break;
        case 2:
            form.action = "http://newcatalog.library.cornell.edu";
            form.callno.name = ""

            break;
        case 3:
            form.action = "http://cornell.worldcat.org/search?qt=wc_org_cornell";
            break;
    }


}
</script>

        

