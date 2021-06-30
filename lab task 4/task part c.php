<!DOCTYPE html>
<html lang="en">
<head>



    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>
<body>
    

        
        <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">  
      <form action="cookie.php" method="post">
        <fieldset style="width: 30%;">      
        <legend>LOGIN:</legend>
        <label for="name">User name:</label>
        <input type="text" id="name" name="name" value=" ""><span class="error"> </span><br><br>
        <label for="password">Password:</label>
        <input type="password" id="password" name="password" value="" ><span class="error"> </span><br><br>
        <hr>
        <input type="checkbox" name="remember" value="remember">
        <label for="click"> Remember Me</label><br>
        <input type="submit" value="Submit">
    
         <a href="forget email.php">Forgot email</a>
        </fieldset>
        </form>

</body>
</html>