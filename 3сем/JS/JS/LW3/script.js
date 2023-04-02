function quest_One(){
    let comment = prompt("Введите комментарий");
    let arr = comment.split(' ');
    comment = " ";
    for(let i = 0; i < arr.length; i++){
        arr[i] = arr[i].replace("пёс", "многоуважаемый пёс");
        arr[i] = arr[i].replace("cобака", "Cобака");
        arr[i] = arr[i].replace("кот", "*");
        comment = comment + " " + arr[i];
    }
    console.log(comment);
//пёс собака, кот пёс собак акот
}

function quest_Two(day){
    let week = {
        "1" : "Пн",
        "2" : "Вт",
        "3" : "Ср",
        "4" : "Чт",
        "5" : "Пт",
        "6" : "Сб",
        "7" : "Вс", 
    }
    switch(day){
        case 1:
            console.log(week["1"]);
            break;
        case 2:
            console.log(week["2"]);
            break;
        case 3:
            console.log(week["3"]);
            break;
        case 4:
            console.log(week["4"]);
            break;
        case 5:
            console.log(week["5"]);
            break;
        case 6:
            console.log(week["6"]);
            break;
        case 7:
            console.log(week["7"]);
            break;
        default:
            console.log("Ошибка ввода")
    }
    let counter = 0;
    for(elem in week){
        if(Number(elem) % 2 != 0){
            counter++;
            console.log(week[elem] + " " + counter)
        }
    }
    console.log("Кол нечётных дней: " + counter)
}

function quest_Three(){
    let button_obj = {
        color : "gray",
        size : "15px",
        height : "10px",
        width : "8 px"
    }
    let src_obj = {
        color : "blue",
        background : "gray"
    }
    let attention = {
        color : "yellow",
        background : "purple"
    }
    Object.assign(button_obj, attention)
    
    document.getElementById("VK").style.color = attention.color;
    document.getElementById("GH").style.color = button_obj.color;
    document.getElementById("кнопка").style.color = src_obj.color;
}

function quest_four(){
    let Products= new Set();
    let end = false;
    do{
        let a = prompt("1) Доабвить товар\n2) Удалить\n3) Проверить наличие")
        switch(Number(a)){
            case 1:
                let name = prompt("Название")
                let amount = prompt("Колличество")
                Products.add(name, amount);
                continue;
            case 2:
                let del = prompt("Введите название")
                Products.delete(del);
                continue;
            case 3:
                let input = prompt("Введите название")
                if(Products.has(input))
                    alert("есть в наличии")
                continue;
            case 4:
                alert("Всего товара: " + Products.size)
                end = true;
        }
    }while(!end);
}
function quest_five(){
    let basket = new Map();
    let counter = 1;
    let potato = {
        amount: 15,
        price: 3
    }
    let carrot = {
        amount: 3,
        price: 5
    }
    let end = false;
    do{
    let a = prompt("1)добавить товар\n2)удалить товар\n3)кол товара\n4)изменить кол товара")
    switch(Number(a)){
        case 1:
            let prod = prompt("1)potato\n2)carrot")
            if(prod = "1")
                basket.set(counter, potato)
            else if(prod = "2")
                basket.set(counter, carrot)
            counter++
            break;
        case 2:
            let id = prompt("Введите ID товара")
            basket.delete(Number(id))
            break;
        case 3:
            let sum = 0;
            for(let i = 1; i <= basket.size; i++){
                let give_obj = basket.get(Number(i))
                sum += Number(give_obj.price)
            }
            alert("Кол товара " + basket.size + "\n сумма заказа " + sum)
            break;
        case 4:
            let prod_id = prompt("Введите Id товара кол которово хотите изменить")
            let price = prompt("цена")
            let give_obj = basket.get(Number(prod_id))
            give_obj.price = 15;
            basket.set(Number(prod_id), give_obj)
            break;
        default:
            end = true;
    }
    }while(!end)
}
//quest_Two(4)
//quest_Three()
//quest_four()
//quest_five()
//https://learn.javascript.ru/weakmap-weakset
//https://learn.javascript.ru/map-set