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
    var pesoEhValido = validaPeso(peso);
    var alturaEhValida = validaAltura(altura);

    // Fazendo Validação


    if (!pesoEhValido) {
        console.log("Peso inválido!");
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido!";
        paciente.classList.add("paciente-invalido")
    }

    if (!alturaEhValida) {
        console.log("Altura inválida!");
        alturaEhValida = false;
        tdImc.textContent = "Altura inválida!";
        paciente.classList.add("paciente-invalido")

    }

    if (alturaEhValida && pesoEhValido) {
        var imc = calculaImc(peso, altura);
        tdImc.textContent = imc;
    }
}

function validaPeso(peso) {
    if (peso >= 0 && peso < 1000) {
        return true;
    }
    else {
        return false;
    }
}

function validaAltura(altura) {

    if (altura >= 0 && altura <= 3.0) {
        return true;
    } else {
        return false;
    }
}

titulo.addEventListener("click", alerta);

function alerta() {
    alert("Click aqui não ow vacilão");
}

// Adicionando função de calcular imc

function calculaImc(peso, altura) {
    var imc = 0;

    imc = peso / (altura * altura);

    return imc.toFixed(2);
}

