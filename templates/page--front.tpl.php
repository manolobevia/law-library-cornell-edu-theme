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
                <!--Cornell University Library / Cornell Law School / Legal Information Institute-->
        </section>

        <!-- HERO CAROUSEL-->

        <section class="hero">

        <?php print render($page['spotlight']); ?>

        </section>

        <!-- LAW BRANDING + MAIN NAVIGATION-->

        <header class="main-nav">

            <h1>
                <a href="/"><img class="law-logo" src="<?php print $theme_path; ?>images/law-logo.png" /></a>
            </h1>

        </header>





        <!-- MAIN NABIGATION / MEGAMENUS -->
        

                <?php print render($page['mega_menu']); ?>
         
        

        <section class="search-home">

            <form id="form1" name="form1" method="get" action="http://newcatalog.library.cornell.edu">
                <label for="name">Search</label>
                <div class="filtered-search">

                    <input type="text" class="form-text" name="q" value="" /><select name="search_type" id="search_type" size="1" onChange="chgAction()" class="form-control filter">

                        <option value="law" selected="selected">Law Collections<span>></span></option>
                        <option value="catalog">Library Catalog</option>
                        <option value="worldcat">WorldCat</option>

                    </select>

                    <div class="hide-select-btn"></div>

                    <input type="hidden" name="f[lc_1letter_facet][]" id ="callno" value ="K - Law">
                    <input type="hidden" name="search_field" value="all_fields">


                    <!--a class="filter" href="#">LAW LIBRARY <span class="caret-icon">></span></a> -->
                    <button type="submit" class="submit-search" href="#"><span class="glyphicon glyphicon-search"></span></button>

                </div>
            </form>         
            
            <ul class="external-search">
                <li><a href="#">My Library Account</a> / </li>
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
                
                <?php print render($page['owlcarousel']); ?>

                <a class="customPrevBtn" href="#"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span></a>

                <a class="customNextBtn" href="#"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span></a>
          
        </section>

    
        <footer class="row">
              <?php print render($page['footer']); ?>
        </footer>


<script>

function chgAction() {

    var form = document.form1;
    
    //console.log('chgAction()');
    //console.log(form.search_type.selectedIndex);
    
    switch (form.search_type.selectedIndex) {
        case 0:
            form.action = "http://newcatalog.library.cornell.edu";
            form.callno.value = "K - Law";
            break;
        case 1:
            form.action = "http://newcatalog.library.cornell.edu";
            form.callno.name = ""
            break;
        case 2:
            form.action = "http://cornell.worldcat.org/search?qt=wc_org_cornell";
            break;
    }
}
</script>

        

