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



<!-- CUL BRANDING  <?php print $theme_path; ?> -->
<section class="cul-branding">
    
        <a href="http://www.lawschool.cornell.edu/" class="cu-logo"></a>

        <nav class="user-tools">

            <ul>
                <li><a class="show-hide-search" title="Search our Site" href="#"><span class="glyphicon glyphicon-search" aria-hidden="true"></span></a></li>
                <li><a class="hours-icon"  title="Today's Hours" href="/about/hourslocation"><span class="glyphicon glyphicon-time" aria-hidden="true"></span></a></li>
                <li><a class="reservations-icon" title="Room Reservations" href="http://spaces.library.cornell.edu/booking/law"><span class="glyphicon glyphicon-calendar" aria-hidden="true"></span></a></li>
            </ul>

        </nav>

</section>




<!-- LAW BRANDING + MAIN NAVIGATION-->
<header class="main-nav">

    <h1>
        <a href="/"><img class="law-logo" src="<?php print $theme_path; ?>images/law-logo.png" /></a>
    </h1>

</header>

<!-- MAIN NAVIGATION / MEGAMENUS -->


<?php print render($page['mega_menu']); ?>


<!-- INTERIOR SEARCH -->
<section class="search-slider">

    <div class="search-interior">

        <!-- Pay attention to METHOD -->
        <form id="search" name="form1" method="get" action="https://newcatalog.library.cornell.edu/search">

            <label for="name">Search <span class="search-filter-selected">Library Catalog</span></label>


            <div class="filtered-search">

                <input type="text" class="search-homepage" name="q" value="" id="edit_keys" />

                <!--<select name="search_type" id="search_type" size="1" onChange="chgAction()" class="form-control filter">

                    <option value="catalog" selected="selected">Library Catalog</option>
                    <option value="worldcat">WorldCat</option>
                    <option value="site">Site Search</option>

                </select>-->

                <div class="filter-search"><span class="active">Library Catalog</span> <span class="glyphicon glyphicon-chevron-down filter-default"></span>

                  <ul id="filter-search-nav">
                      <li role="listitem"><a href="#" title="">Library Catalog</a></li>
                      <li role="listitem"><a href="#" title="">WorldCat</a></li>
                      <li role="listitem"><a href="#" title="">Site Search</a></li>
                  </ul>

              </div>

              

                <!--a class="filter" href="#">LAW LIBRARY <span class="caret-icon">></span></a> -->
                <button type="submit" class="submit-search" href="#">
                  <span class="glyphicon glyphicon-search"></span>
                </button>

            </div>

            <ul class="external-search">
              <li><a href="https://www.library.cornell.edu/myacct">My Library Account</a> / </li>
              <li><a href="http://guides.library.cornell.edu/onlinelegalresources">Databases</a> / </li>
              <li><a href="http://guides.library.cornell.edu/LAW">Research Guides</a></li>
            </ul>
        </form>         
    
    </div>

</section>

<a href="#" class="close-search">
  <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
</a>

<!-- HEADER IMAGE -->
<section class="header-interior"><div class="mask-interior"></div></section>
    
<!-- CONTENT -->

<?php
    // Render the sidebar to see if there's anything in them.
    $sidebar  = render($page['sidebar_second']);
?>


<section class="row page-content">

    <!--if there is a sidebar, then create two column layout-->
    <?php if ($sidebar): ?>

    <div class="col-xs-12 col-sm-12 col-md-10 col-lg-10 main-content">
        <nav class="breadcrumb">

            <?php print render($breadcrumb); ?>
           <!--  <a href="#">About</a> <span class="separator">></span>
            <strong>Our Space</strong> -->
        </nav> 

        <header class="page">
            <h2 class="title-content"><?php print $title; ?></h2>
        </header>
        <?php print $messages; ?>
        <?php print render($tabs); ?>
		<?php print render($page['content']); ?>
	</div>

    <sidebar class="col-xs-12 col-sm-12 col-md-2 col-lg-2 sidebar-nav">
         <?php print $sidebar; ?>
    </sidebar>

    <!--if there isn't a sidebar, then create one column layout-->
    <?php else :?>

    <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 main-content-one-column">
        <nav class="breadcrumb">

            <?php print render($breadcrumb); ?>
           <!--  <a href="#">About</a> <span class="separator">></span>
            <strong>Our Space</strong> -->
        </nav> 

        <header class="page">
            <h2 class="title-content"><?php print $title; ?></h2>
        </header>
        <?php print $messages; ?>
        <?php print render($tabs); ?>
        <?php print render($page['content']); ?>
    </div>

    <?php endif; ?>

</section>


<footer class="row">
      <?php print render($page['footer']); ?>
</footer>

		
        