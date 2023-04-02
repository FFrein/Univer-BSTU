"use strict"

function QuestOne() {
    let count = 0;
    for (var i = 0; i < arguments.length; i++) {
        count++
      }
    if(count > 7){
        console.log("Много аргументов")
        return
    }
    if(count > "5"){
        console.log("Колл аргументов: " + arguments.length)
        return
    }
    if(count > 3){
        console.log("Типы аргументов")
        for (var i = 0; i < arguments.length; i++) {
            console.log( typeof(arguments[i]) );
          }
          return
    }
    if(count < 3)
        console.log("String");
}


function Quest2(){
    let choise = prompt("Номер")
    switch(Number(choise))
    {
        case 1:
        window.a1;
        alert (a1);
        break;
        case 2:
        alert (a2);
        window.a2 = 2;
        break;
        case 3:
        alert(a3);
        window.a3 = 2;
        let a3;
        break;
        case 4:
        alert(a4);
        window.a4 = 2;
        var a4;
        break;
        case 5:
        alert(a5);
        let a5 = 2;
        break;
        case 6:
        let a6 = 2;
        window.a6 = 3
        alert(a6);
        break;
        case 7:
        var a7 = 2;
        window.a7 = 3;
        alert(a7);
        break;
        case 8:
        let s = 5;
        function sum(){
            alert(s);
        }
        
        sum();
    }
}



function Quest3(){
    

    function makeCounter() {
        let currentCount = 1;
    return function() {
            return currentCount++;
        };
    }

    let counter = makeCounter();
    console.log( counter );

    console.log( counter() ); // 1
    console.log( counter() ); // 2
    console.log( counter() ); // 3

    let counter2 = makeCounter();
    console.log( counter2() ); // 4
    //Вариант 2
    let currentCount2 = 1;

    function makeCounter2() {
    return function() {
            return currentCount2++;
        };
    }

    let counter_2 = makeCounter2();
    let counter_2_2 = makeCounter2();

    console.log( counter_2(2) ); // 2
    console.log( counter_2() ); // 1
    
    console.log( counter_2_2() ); // 4
    console.log( counter_2_2() ); // 3
}


function Quest4(){
    console.log(QuestOne.name)
    console.log(Quest2.name)
    console.log(Quest3.name)
}



function Quest6(){
    function volume(){
        return (b) => {
            return (c) => {
                return a * b * c;
                }
            }
        }
        
        alert(`Объем 1: ${volume(1)(2)(3)}`);

        let volume2 = volume(2);
        alert(`Объем 2: ${volume2(5)(6)}`);
}



function Quest7_Main(){
    function* Quest7() {
        var a;
        let x = 0;
        let y = 0;
        let direction;
        
        for (let i = 0; i < 10; i++) 
        {
            direction = (a = prompt("Введите направление")) !== null && a !== void 0 ? a : "default"; // Проверка на null и undefined
            switch (Number(direction)) 
            {
                case 4:
                    x--;
                    break;
                case 6:
                    x++;
                    break;
                case 8:
                    y++;
                    break;
                case 2:
                    y--;
                    break;
            }
                yield [x, y]; // Возвращаем массив с координатами
        }
    }
      
    let generator = Quest7();
        for (let i = 0; i < 5; i++) {
        alert(generator.next().value);
    }
}

let a = 1, b = "2", c = 3, d, i = 5, f = 6, g = 7, h = 8

//QuestOne(a);
//QuestOne(a, b, c, d);
//QuestOne(a, b, c, d, i, f);
//QuestOne(a, b ,c ,d, i, f, g, h);

//Quest2();

Quest3();

//Quest4()

//Quest6();

//Quest7_Main();