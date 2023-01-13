<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSV Importer</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
</head>

<body class="d-flex align-items-center justify-content-center">
    <main class="m-5 col-8">

        <!-- ------------- -->

        <form action="" enctype="multipart/form-data" method="POST">
            <input type="file" class="form-control" name="importcsv" accept="text/csv" id="">
            <button class="btn btn-success mt-3">Import</button>
        </form>


        <table class="table border mt-3">
            <thead class="table-dark">
                <tr>
                    <th scope="col">Row</th>
                    <th scope="col">First Name</th>
                    <th scope="col">Last Name</th>
                    <th scope="col">Age</th>
                </tr>
            </thead>
            <tbody>
                <?php
                // Check File Upload
                if (isset($_FILES["importcsv"])) {
                    // Variables
                    $address = $_FILES["importcsv"]["tmp_name"];
                    $type = $_FILES["importcsv"]["type"];
                    $number = 0;
                    // Check File Type
                    if ($type == "text/csv") {
                        // Open File
                        $open = fopen($address, "r");
                        // Read CSV Witj fgetcsv
                        while (($row = fgetcsv($open, 1000, ",")) !== false) {
                            $number++;
                ?>

                            <tr>
                                <th scope="row"><?= $number ?></th>
                                <td><?= $row[0] ?></td>
                                <td><?= $row[1] ?></td>
                                <td><?= $row[2] ?></td>
                            </tr>

                        <?php
                        }
                    } else {
                        ?>
                        <!-- Show Error -->
                        <div class="alert alert-danger mt-3">Error In File Format</div>
                <?php
                    }
                }
                ?>
            </tbody>
        </table>
    </main>
</body>

</html>