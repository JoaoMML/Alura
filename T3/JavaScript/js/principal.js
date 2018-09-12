var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista";


// Buncando o peso do primeiro paciente 
var pacientes = document.querySelectorAll(".paciente");

for (var i = 0; i < pacientes.length; i++) {

    paciente = pacientes[i];

    var Tdpeso = paciente.querySelector(".info-peso");
    var peso = Tdpeso.textContent;

    // Buscando altura

    var Tdaltura = paciente.querySelector(".info-altura");
    var altura = Tdaltura.textContent;

    var tdImc = paciente.querySelector(".info-imc");

    // criando variaveis de controle
    var pesoEhValido = true;
    var alturaEhValida = true;

    // Fazendo Validação


    if (peso <= 0 || peso >= 1000) {
        console.log("Peso inválido!");
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido!";
        paciente.classList.add("paciente-invalido")
    }

    if (altura <= 0 || altura >= 3.00) {
        console.log("Altura inválida!");
        alturaEhValida = false;
        tdImc.textContent = "Altura inválida!";
        paciente.classList.add("paciente-invalido")
        
    }

    if (alturaEhValida && pesoEhValido) {
        var imc = peso / (altura * altura);
        tdImc.textContent = imc.toFixed(2);
    }
}
