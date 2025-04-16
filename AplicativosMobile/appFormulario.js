import {useState} from 'react';
import { StyleSheet, Text, View, TextInput, TouchableOpacity } from 'react-native';

import { Picker } from '@react-native-picker/picker';
import Slider from '@react-native-community/slider';
import { Switch } from 'react-native-paper';
import {RadioButton} from 'react-native-paper';

export default function App() {
  const [nome,setNome] = useState('');
  const [carro,setCarro] = useState('');
  const [placa,setPlaca] = useState('');
  const [modelo,setModelo] = useState(0);
  const [valor,setValor] = useState(15000);
  const [utilitario,setUtilitario] = useState(false);
  const [checked,setChecked] = useState('Masculino');
 
  return (
    <View style={styles.container}>
      <Text style={styles.titulo}>Informações do Carro Particular</Text>
      <View style={styles.areaformulario}>
        <Text style={styles.textoNome}>Nome Pessoa:</Text>
        <TextInput
          style={styles.input}
          placeholder="Digite seu nome aqui"
          onChangeText={setNome}
        >
        </TextInput>

        <View style={styles.areaRadio}>
          <RadioButton
            value="Masculino"
            status= {checked == "Masculino" ? 'checked' : 'unchecked'}
            onPress={setChecked('Masculino')}
          >
          </RadioButton>
          <Text>Masculino</Text>

          <RadioButton
            value="Feminino"
            status= {checked == "Feminino" ? 'checked' : 'unchecked'}
            onPress={setChecked('Feminino')}
          >
          </RadioButton>
          <Text>Feminino</Text>
        </View>
        <Text style={styles.textoNome}>Nome Carro:</Text>
        <TextInput
          style={styles.input}
          placeholder='Digite o nome do carro'
          onChangeText={setCarro}
        >
        </TextInput>

        <Text style={styles.textoNome}>Placa do Carro:</Text>
        <TextInput
          style={styles.input}
          placeholder='Digite a placa do carro'
          onChangeText={setPlaca}
        >
        </TextInput>

        <View style={styles.areaModelo}>
          <Text style={styles.textoNome}>Modelo:</Text>
          <Picker
            style={styles.pickerModelo}
            selectedValue={modelo}
            onValueChange={(itemValue) => setModelo(itemValue)}
          >
            {/*{modeloItems}*/}
          </Picker>

        </View>

        <View style={styles.ValorCarro}>
          <Text styel={styles.textoNome}>Valor do carro:</Text>
          <Text style={styles.carroTexto}>R$(valor.toFixed(0))</Text>
        </View>

        <View style={styles.areaSlider}> 
          <Slider
          maximumTrackTintColor='#cfo'
          minimumValue={15000}
          maximumValue={2400000}
          value={valor}
          onValueChange={setValor}
          
          ></Slider>
        </View>

      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});

