var pacientes = document.querySelectorAll(".paciente");

var tabela = document.querySelector("table");

tabela.addEventListener("dblclick", function(event){
    var alvoDoEvento = event.target;
    var paiDoAlvo = alvoDoEvento.parentNode;

    paiDoAlvo.remove();
})