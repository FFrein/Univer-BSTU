'use strict'

//Function Declaration
function F_Dec() { console.log( "Function Declaration" ); }
  
//Function Expression
let F_Exp = function() {console.log( "Function Expression" ); };

let F_arrow = ()=> console.log("Function Arrow");

let FuncQuest2 = (a = "strt",b,c)=> console.log(a+b+c);

let FuncQuest3 = ()=> {
    let arr = new Array();
    let counter = 0;
    do{
    arr[counter] = prompt("Ввод студентов. Введите exit если хотите закончить")
    if(arr[counter] == "exit") break;
    counter++
    delete arr[0];
    }while(true)

    console.log("Кол студентов: " +counter)
}

let FuncQuest4 = ()=> {
//5 букв 3 цифры - пароль
//26 букв 10 цивр
let broodforcetime = (26 ** 5 * 10 ** 3) * 3;
let second = broodforcetime % 60;
let minutes = Math.floor(broodforcetime/60) % 60;
let allh = Math.floor(broodforcetime/60);
let houres = (Math.floor(allh/60)) % 24 ;
let alld_help = (Math.floor(allh/60));
let alld = Math.floor(alld_help/24);
let days = alld % 30;
let allm = Math.floor(alld/30);
let mounth = allm % 12;
let year = Math.floor(allm/12);
console.log(second + "s" + minutes + "min" + houres + "h"
+ days + "d" + mounth + "m" + year + "y")
}

let FuncQuest5 = ()=> {
    let number5 = prompt("Введите число");
    if(parseInt(number5)){
        if(Number.isInteger((Number(number5)))){
            console.log((+number5).toString(16))
          }
        else{
            console.log(Math.floor(number5))//в меньшую
            console.log(Math.ceil(number5))//в большую
            console.log(Math.round(number5))//до ближайшего целого
        }
    }
    else{
        console.log(number5.toLowerCase())
    }
}

let FuncQuest6 = ()=> {
    let word = prompt("словарное слово =\n"+
    "словарное слово\nсловарнае слава\nсолёное сало");
    const slword = "словарное слово";
    for(let i = 0; i < slword.length; i++){
        if(word[i] != slword[i])
            console.log("Ошибка на позиции: " + (i + 1));
    }
}

let FuncQuest7 = ()=> {
    let katet_one = prompt("Введите длинну катета 1");
    let katet_two = prompt("Введите длинну катета 2");
    let hypoten = Math.sqrt(katet_one **2 + katet_two **2);
    console.log(katet_two * katet_one / 2 + " Площадь")
    console.log(hypoten +" Гипотинуза");
    let sinus = (katet_two / hypoten)
    let cosinus = (katet_one / hypoten)
    console.log(sinus)
    console.log(cosinus)
    console.log((sinus / cosinus));
    console.log((cosinus / sinus));
    
}

const FOUR = 4;

FuncQuest2(undefined, FOUR, input)

FuncQuest3();

//FuncQuest4();

//FuncQuest5();

//FuncQuest6();

//FuncQuest7();