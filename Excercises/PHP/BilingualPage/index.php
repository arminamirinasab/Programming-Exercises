<?php
// Check Get Request For Set Array
if (isset($_GET["lang"]) && $_GET["lang"] == "ru") {
    include_once "langs/ru.php";
} else {
    include_once "langs/en.php";
}
?>
<!-- Dont Care Design , Its Only Show Bilingual Mechanism -->
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Armin Amiri Nasab</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css">
    <link rel="stylesheet" href="./css/style.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.0/jquery-ui.min.js"></script>
    <script type="text/javascript" src="https://twitter.github.io/bootstrap/assets/js/bootstrap-transition.js"></script>
</head>

<body>
    <nav class="navbar navbar-default navbar-fixed-top topnav" role="navigation">
        <div class="container topnav">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <a class="navbar-brand topnav" href="?lang=en">English</a>
                <a class="navbar-brand topnav" href="?lang=ru">Russian</a>
            </div>
        </div>
        <!-- /.container -->
    </nav>
    <div id="home" class="intro-header">
        <div class="container">
            <div class="row">

                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <div class="intro-message">
                        <h1 style="text-align: center;"><?= $str["name"] ?></h1>

                        <h2 style="text-align: center;"><?= $str["work"] ?></h2>

                        <hr class="intro-divider">
                        <p style="text-align: center;">
                            <a href="https://www.github.com/arminamirinasab" class="btn btn-default btn-lg" role="button" target='_blank'><span class="icon fa fa-github" aria-hidden="true"></span> Github
                            </a> &nbsp; &nbsp;&nbsp;<a href="https://www.linkedin.com/in/arminamirinasab/" class="btn btn-default btn-lg" role="button" target='_blank'><span class="icon fa fa-linkedin" aria-hidden="true"></span>
                                Linkedin</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="content-section-a " id="about" style="padding-top: 54px;" class="section-heading">
        <div class="container">
            <div class="row">

                <div class="col-xs-12 col-sm-9 col-md-9 col-lg-9">

                    <div style="padding-left: 30px;">
                        <p style="text-align: right;">&nbsp;</p>

                        <hr style="float: right;" class="section-heading-spacer">
                        <div style="text-align: right;" class="clearfix">&nbsp;</div>

                        <h2 style="text-align: right;"><?= $str["about-title"] ?></h2>

                        <p style="text-align: right;" class="lead"><?= $str["about"] ?></p>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <div id="skill" class="content-section-b" style="padding-top: 54px;">
        <div class="container">
            <div class="row">

                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                    <hr class="section-heading-spacer">
                    <div class="clearfix">&nbsp;</div>

                    <h2 class="section-heading"><?= $str["skill-title"] ?>&nbsp;</h2>

                    <p class="lead"><?= $str["skill"] ?></p>


                </div>

                <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6">

                    <div style="padding-top: 53px;">
                        <div class="progress">
                            <div style="width: 60%; float: left;" class="progress-bar progress-bar-success progress-bar-striped active"><span class="sr-only">60% Complete</span>Python</div>
                        </div>

                        <div class="progress">
                            <div style="width: 80%;" class="progress-bar progress-bar-info progress-bar-striped active"><span class="sr-only">80% Complete</span>Wordpress</div>
                        </div>

                        <div class="progress">
                            <div style="width: 60%;" class="progress-bar progress-bar-warning progress-bar-striped active"><span class="sr-only">60% Complete (warning)</span>HTML and CSS</div>
                        </div>

                        <div class="progress">
                            <div style="width: 70%;" class="progress-bar progress-bar-danger progress-bar-striped active"><span class="sr-only">70% Complete (danger)</span>SQL</div>
                        </div>
                    </div>

                </div>


            </div>
        </div>
    </div>

    <div id="contact" class="banner">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">

                    <h2 style="text-align: right;" class="lead"><?= $str["getintouch"] ?></h2>
                    <form action="index.php" class="form-horizontal" method="post">
                        <div class="form-group">
                            <p><label class="col-sm-2 control-label" for="name"><?= $str["formname"] ?></label></p>

                            <div class="col-sm-10"><input class="form-control" id="name" name="name" type="text" value=""></div>
                        </div>

                        <div class="form-group">
                            <p><label class="col-sm-2 control-label" for="email"><?= $str["formemail"] ?></label></p>

                            <div class="col-sm-10"><input class="form-control" id="email" name="email" type="email" value=""></div>
                        </div>

                        <div class="form-group">
                            <p><label class="col-sm-2 control-label" for="message"><?= $str["formmessage"] ?></label></p>

                            <div class="col-sm-10"><textarea name="message" class="form-control" rows="4"></textarea></div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-10 col-sm-offset-2"><input class="btn btn-primary" id="submit" name="submit" type="submit" value="<?= $str["formsend"] ?>"></div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-10 col-sm-offset-2">&nbsp;</div>
                        </div>
                    </form>

                </div>

                <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4">

                    <div style="padding-top: 72px; padding-left: 30px;">

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title"><?= $str["contactinfo"] ?></h3>
                            </div>

                            <div class="panel-body">

                                <div style="color: black;">
                                    <p>
                                        <span class="icon fa fa-location-arrow" aria-hidden="true"></span>
                                        &nbsp;<?= $str["address"] ?>
                                    </p>

                                    <p>
                                        <span class="icon fa fa-envelope-o" aria-hidden="true"></span>
                                        &nbsp;<?= $str["email"] ?>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>


            </div>
        </div>
    </div>
    <footer>
        <div class="container">
            <hr>
            <p><?= $str["footer"] ?></p>
        </div>
    </footer>
</body>

</html>