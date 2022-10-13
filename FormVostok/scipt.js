var cbCity = document.querySelector(".cbCity");
var optionCity = ["Омск", "Москва", "Санкт-Петербург", "Новосибирск", "Тюмень"];
glson(optionCity, cbCity);

var cbWorkshop = document.querySelector(".cbWorkshop");
var optionWorkshop = ["1-й Цех", "2-й Цех", "3-й Цех", "4-й Цех", "5-й Цех"];
glson(optionWorkshop, cbWorkshop);

var cbEmployee = document.querySelector(".cbEmployee");
var optionEmployee = ["1-й работник", "2-й работник", "3-й работник", "4-й работник", "5-й работник"];
glson(optionEmployee, cbEmployee);

var cbBrigade = document.querySelector(".cbBrigade");
var optionBrigade = ["1-я бригада", "2-я бригада"];
glson(optionBrigade, cbBrigade);

var cbShift = document.querySelector(".cbShift");
var optionShift = ["Смена с 08:00 до 20:00", "Смена с 20:00 до 08:00"];
glson(optionShift, cbShift);

var combo = document.querySelectorAll(".comboBox");
var form = document.querySelector(".form");


form.addEventListener("change", function(){
    qq();
});

function qq(){
    for(var i = 0; i < optionWorkshop.length; i++){
        document.querySelector(".cbWorkshop > option").remove();
    }

    for(var i = 0; i < optionShift.length; i++){
        document.querySelector(".cbShift > option").remove();
    }


    if(cbBrigade.value == "1-я бригада"){
        optionShift = ["Смена с 08:00 до 20:00"];
    }
    else if(cbBrigade.value == "2-я бригада"){
        optionShift = ["Смена с 20:00 до 08:00"];                 
    }
    glson(optionShift, cbShift);

    if(cbCity.value == "Омск"){
        optionWorkshop = ["1-й Цех"];
    }
    else if(cbCity.value == "Москва"){
        optionWorkshop = ["2-й Цех"];
    }
    else if(cbCity.value == "Санкт-Петербург"){
        optionWorkshop = ["3-й Цех"];
    }
    else if(cbCity.value == "Новосибириск"){
        optionWorkshop = ["4-й Цех"];
    }
    else if(cbCity.value == "Тюмень"){
        optionWorkshop = ["5-й Цех"];
    }
    glson(optionWorkshop, cbWorkshop);
}



function glson(arr, elem){
    for(var i=0; i < arr.length; i++){
        var opt = arr[i];
        var el = document.createElement("option");
        el.textContent = opt;
        el.value = opt;
        elem.appendChild(el);
    }
}


