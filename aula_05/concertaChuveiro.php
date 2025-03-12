<?php
$situacao= "Chuveiro queimado";

//Implementação da função
function concertarChuveiro(){
    $situacao = "Chuveiro concertado! <br>";
    return $situacao;
}
//Chamando e executando a função

$situacao = concertarChuveiro();

echo $situacao;

?>