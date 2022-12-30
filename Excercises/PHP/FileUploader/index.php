<?php
// Message
$message = "The files will upload in the uploads folder.";
// Check File
if (isset($_FILES["file"])) {
  // File Variables
  $name = $_FILES["file"]["name"];
  $type = $_FILES["file"]["type"];
  $size = floor($_FILES["file"]["size"] / 1024);
  $tmp = $_FILES["file"]["tmp_name"];
  // Check Size
  if (!($size > 8388608)) {
    // Allowed Extensions
    $exts = ["image/jpg", "image/png", "image/jpeg"];
    // Check Extension
    if (in_array($type, $exts)) {
      // Hash Name
      $filename = md5($name . microtime()) . substr($name, -4, 5);
      // Move File
      $move = move_uploaded_file($tmp, "./uploads/$filename");
      // Check & Change Message
      if ($move) $message = "File $name Uploaded Successfuly";
      // Error Messages =>
    } else {
      $message = "Extension Not Allowed OR https Can't Handle This File";
    }
  } else {
    $message = "The uploaded file is larger than 8 MB.";
  }
}
?>


<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
  <link rel="stylesheet" href="./assets/css/style.css">
  <title>PHP File Uploader</title>
</head>

<body>
  <h1>PHP File Uploader</h1>
  <h4><?= $message ?></h4>
  <div class="container p-4">
    <form method="POST" enctype="multipart/form-data">
      <input class="form-control" type="file" name="file" required>
      <input type="submit" value="Upload File" class="form-control mt-4 btn btn-primary">
    </form>
  </div>

</body>

</html>