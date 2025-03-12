<?php

function volume($altura, $comprimento , $profundidade){
    $volume = $altura * $profundidade * $comprimento;

    return $volume;
}

echo volume(3,3,3);

?>