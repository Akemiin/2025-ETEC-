<h1>Aula 05 - Funções</h1>

<?php

function votar(){
    $idade = 16;

    if( $idade >= 18){
        $resultado = "Você deve votar!";
    }

    else if( $idade >= 16 && $idade <= 17){
        $resultado = "Você já pode votar!";
    }

    else{
        $resultado = "Você ainda é muito novo para votar";
    }

    echo $resultado;
    
}

    votar();

?>