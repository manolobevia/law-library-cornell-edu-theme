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

<!-- CUL BRANDING -->
        <section class="cul-branding">
                <img class="cu-logo" src="/sites/all/themes/law_library_bootstrap/images/cul-branding/cu-logo.png" />
        </section>

        <!-- LAW BRANDING + MAIN NAVIGATION-->
        <header class="main-nav">

            <h1>
                <img class="law-logo" src="/sites/all/themes/law_library_bootstrap/images/law-logo.png" />
            </h1>
            
            <ul>
                <li><a class="active" href="/" title="">HOME</a> /</li>
                <li><a href="#" title="">ABOUT <span class="caret-icon">></span></a> /</li>
                <li><a href="#" title="">USING THE LIBRARY <span class="caret-icon">></span></a> /</li>
                <li><a href="#" title="">RESEARCH <span class="caret-icon">></span></a> /</li>
                <li><a href="#" title="">EXPLORE</a></li>
                <li><a href="#" title="">SPECIAL COLLECTIONS <span class="caret-icon">></span></a> /</li>
                <li><a href="#" title="">OTHER COLLECTIONS <span class="caret-icon">></span></a></li>
            </ul>

        </header>

        <?php print render($page['Navigation']); ?>

        <!-- HERO CAROUSEL-->

        <section class="hero">
            <img src="/sites/all/themes/law_library_bootstrap/images/carousel-home/carousel-image-1.jpg" />

            <section class="search-home">

                <form action="/">
                    <label for="name">Search</label>
                    <div class="filtered-search">

                        <input type="text" class="form-text" value="" /><a class="filter" href="#">LAW LIBRARY <span class="caret-icon">></span></a>
                        <a class="submit-search" href="#"><span class="glyphicon glyphicon-search"></span></a>
                    </div>
                </form>         
                
                <ul class="external-search">
                    <li><a href="#">Books in other libraries</a> / </li>
                    <li><a href="#">Databases</a> / </li>
                    <li><a href="#">Research Guides</a></li>
                </ul>

            </section>
        </section>


        <section class="media row">

            <div class="rs-carousel">

                <div class="carousel-prev"></div>

                <div class="carousel-wrapper">


                    <ul class="media-items">
                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>
                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>
                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-2.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>

                        <li class="media-item"> 
                          
                            <figure>
                                <a href="#"><img class="image-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/media-item-1.jpg" />
                                <img class="mask-media" src="/sites/all/themes/law_library_bootstrap/images/carousel-media/mask-media.png" /></a>

                                <figcaption>
                                    Law Library will host Cornell Companions, a pet visitation program
                                </figcaption>                    
                            </figure>

                        </li>
                    </ul>
                    
                </div>

                <div class="carousel-next"></div>
                
            </div>
        </section>

    
        <footer class="row">
              <?php print render($page['footer']); ?>
        </footer>


        <!-- Carousel https://github.com/richardscarrott/jquery-ui-carousel -->
        <!-- carousel CSS -->
        <link rel="stylesheet" type="text/css" href="/sites/all/themes/law_library_bootstrap/js/jquery-ui-carousel-master/css/jquery.rs.carousel.css" media="all" />

        <!-- lib -->

        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery.ui.widget.js"></script>
        <!-- if using touch -->
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery.event.drag.js"></script>
        <!-- if using touch and translate3d -->
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery.translate3d.js"></script>

        <!-- carousel core -->
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery-ui-carousel-master/js/jquery.rs.carousel.js"></script>

        <!-- carousel extensions (optional) -->
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery-ui-carousel-master/js/jquery.rs.carousel-autoscroll.js"></script>
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery-ui-carousel-master/js/jquery.rs.carousel-continuous.js"></script>
        <script type="text/javascript" src="/sites/all/themes/law_library_bootstrap/js/jquery-ui-carousel-master//js/jquery.rs.carousel-touch.js"></script>

