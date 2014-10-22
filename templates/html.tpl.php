<?php
$theme_path = base_path() . 'sites/all/themes/law_library_bootstrap/';
?>

<!DOCTYPE html>

<html lang="en">
    <head>
        <?php print $head; ?>
        <meta charset="UTF-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
       
        <title><?php print $head_title; ?></title>

        <meta name="description" content="" />
        <meta name="keywords" content="" />
        <meta name="author" content="" />
        <!--<link rel="shortcut icon" href="../favicon.ico">-->

        <meta name="viewport" content="width=device-width, initial-scale=1.0"> <!-- removing initial-scale=1.0 disables zooming capabilities -->

        <!-- Google fonts -->
        <link href='http://fonts.googleapis.com/css?family=Libre+Baskerville:400,700' rel='stylesheet' type='text/css'>
        <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>

        <?php print $styles; ?>

        <!-- Optional theme -->
        <link href="<?php print $theme_path; ?>css/styles.css" rel="stylesheet" media="screen">

        
        

        <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!--[if lt IE 9]>
          <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
          <script src="http://cdnjs.cloudflare.com/ajax/libs/respond.js/1.4.2/respond.js"></script>
        <![endif]-->

        <!--[if gte IE 9]>
        <![endif]-->

        <?php print $scripts; ?>


    </head>

    <body class="homepage <?php print $classes; ?>" <?php print $attributes;?>>

    <?php print $page_top; ?>
    <?php print $page; ?>
    <?php print $page_bottom; ?>


    <script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script src="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>

    <!-- Carousel https://github.com/richardscarrott/jquery-ui-carousel -->
    <!-- carousel CSS -->
    <link rel="stylesheet" type="text/css" href="<?php print $theme_path; ?>js/jquery-ui-carousel-master/css/jquery.rs.carousel.css" media="all" />

    <!-- lib -->

    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery.ui.widget.js"></script>
    <!-- if using touch -->
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery.event.drag.js"></script>
    <!-- if using touch and translate3d -->
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery.translate3d.js"></script>

    <!-- carousel core -->
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery-ui-carousel-master/js/jquery.rs.carousel.js"></script>

    <!-- carousel extensions (optional) -->
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery-ui-carousel-master/js/jquery.rs.carousel-autoscroll.js"></script>
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery-ui-carousel-master/js/jquery.rs.carousel-continuous.js"></script>
    <script type="text/javascript" src="<?php print $theme_path; ?>js/jquery-ui-carousel-master//js/jquery.rs.carousel-touch.js"></script>


    <!-- Utils -->
    <script type="text/javascript" src="<?php print $theme_path; ?>js/utils.js"></script>
    








    </body>
</html>