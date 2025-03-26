<h1>Aula 05 - Funções</h1>

<?php

//Criando a função saudacão

function saudacao(){
    $hora = 13;

    if( $hora >= 6 && $hora <= 12){
        $saudacao = "Bom dia!";
    }

    else if( $hora >= 13 && $hora <= 18){
        $saudacao = "Boa tarde!";
    }

    else{
        $saudacao = "Boa noite!";
    }
    echo $saudacao
}

// chamando a função saudação
saudacao();
?>
