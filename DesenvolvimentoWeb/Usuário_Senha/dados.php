<?php
session_start();
$usuario = $_POST['usuario'];
$senha = $_POST['senha'];

if($usuario =='admin' and $senha == '1234'){
    echo 'usuário autenticado com sucesso! <br>';
    echo 'Usuário : ' . $usuario . '</br>';
    echo 'Senha : ' . $senha;
}

else{
    echo 'usuário ou senha incorretos';
    header('Location: Inicial.php');
    $_SESSION['login_invalido']= '';
}

?>