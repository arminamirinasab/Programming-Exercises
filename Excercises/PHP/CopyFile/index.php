<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Copy & Rename File</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>

<body class="m-5">
<?php
// Check POST Request
if (isset($_POST["rename"]) && !empty($_POST["rename"])) {
    // Copy
    $copyOper = copy("fsociety.jpg", "copies/" . $_POST["rename"] . ".jpg");
    // Show Messages
    if ($copyOper) {
        echo '<div class="alert alert-success" role="alert">
        File created successfully ! <a class="text-decoration-none" href="copies/' . $_POST["rename"] . '.jpg">Show Me</a>
      </div>';
    } else {
        echo '<div class="alert alert-danger" role="alert">
        There was a problem creating the file.
      </div>';
    }
}

?>

    <?php
    // Check Origin File
    if (file_exists("fsociety.jpg")) {
    ?>
        <form action="" method="POST">
            <label for="" class="form-label text-capitalize">The name of the new file:</label>
            <input type="text" class="form-control my-2" name="rename" placeholder="">
            <button class="btn btn-primary my-2">New Copy</button>
        </form>


    <?php
    } else {
        echo "Error In Find fsociety.jpg In Root Folder";
        die;
    }
    ?>
</body>

</html>