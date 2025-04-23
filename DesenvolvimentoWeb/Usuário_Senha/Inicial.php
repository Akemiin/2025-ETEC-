<?php
session_start();
?>

<h1> Aula 08 - Métodos Get e Post </h1>

<form action ="dados.php" method = "POST">
    <label for="">Usuário: </label>
    <input type="text" name = "usuario">
    <br>
    <label for=""> Senha: </label>
    <input type="password" name = "senha">
    <br>
    <button>Login</button>
</form>

<?php

if(isset($_SESSION['login_invalido'])){
    echo "usuário ou senha incorretos";
    unset($_SESSION['login_invalido']);
}

