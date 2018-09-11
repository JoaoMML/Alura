var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista"


// Buncando o peso do primeiro paciente 
var paciente = document.querySelector("#primeiro-paciente");
var Tdpeso = paciente.querySelector(".info-peso");
var peso = Tdpeso.textContent; 

// Buscando altura

var Tdaltura = paciente.querySelector(".info-altura");
var altura = Tdaltura.textContent;

// Fazendo calculo do Imc

var imc = peso/ (altura*altura);

console.log (peso);
console.log (altura);
console.log (imc);
// Busca pela caixa do Imc
var Tdimc = paciente.querySelector(".info-imc");
// Exibindo na tela o valor calculado
Tdimc.textContent = imc;
