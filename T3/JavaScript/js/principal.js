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


// criando variaveis de controle
var pesoEhValido = true;
var alturaEhvalida=true;

// Fazendo Validação

if (peso <= 0 || peso >= 1000){
    console.log("Peso inválido");
    pesoEhValido=false;
    Tdimc.textContent ="Peso inválido"; 
}
if (altura <= 0 || altura >= 300){
    console.log("Altura inválida");
    alturaEhvalida = false;
    Tdimc.textContent="Altura inválida";
}

if(pesoEhValido && alturaEhValida) {
   var imc = peso / ( altura * altura); 
}

// Busca pela caixa do Imc
var Tdimc = paciente.querySelector(".info-imc");
// Exibindo na tela o valor calculado
Tdimc.textContent = imc;
