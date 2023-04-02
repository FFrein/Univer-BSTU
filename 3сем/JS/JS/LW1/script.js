"use strict"

let result = null > undefined;
alert(result);
//3
let userName;
let cityName;
let birthday;
const RED_COLOR = "#FF0000";
let userAnswer;
let infinity = 1 / 0;
let number = 532;
let p_square = 120;
let userErrAnswer = "Введённые даннные неверны";
//4
let p_square_2 = (45 + 21) * 2;

alert(p_square_2 + "мм");
//5
alert(p_square_2 / 5);
//6
let i = 2;
let a = ++i;
let b = i++;

if (a > b) alert("a больше");
else if (a == b) alert("a равно b");
else alert("b больше");

//7
function objComparison(a, b) {
  if (a > b) alert(a + " больше");
  else if (a == b) alert(a + " равно " + b);
  else alert(b + " больше");
}

objComparison("Привет","привет");
objComparison("Привет","Пока");
objComparison(45, "53");
objComparison(false, 3);
objComparison(true, "3");
objComparison(3, "5мм");
objComparison(null, undefined);

//8
alert(userErrAnswer);
//9
userAnswer = prompt("Введите ответ на секретный вопрос");
if (userAnswer == "Олень") alert("Какаду");
else alert("Дятел");
//10
const userLogin = "Student";
const userPass = "FitFit";

let login = prompt("Введите логин");
let pass = prompt("Введите пароль");

if (login == userLogin & pass == userPass) alert("Успешный вход");
else alert("Неверный ввод данных");
//11
let mathMark = prompt("Введите оценку по математике");
let engMark = prompt("Введите оценку по английскому");
let rusMark = prompt("Введите оценку по русскому");

if (mathMark >= 4 && engMark >= 4 && rusMark >= 4) alert("Вы прошли на следующий курс");
else if (mathMark < 4 && engMark < 4 && rusMark < 4) alert("Вас отчислят");
else alert("Вас ждёт пересдача");

//12
let numbA = prompt("A=");
let numbB = prompt("B=");
alert("sum = " + (Number(numbA) + Number(numbB)));

//13
alert(true + true);
alert(0 + "5");
alert(5 + "мм");
alert(8 / Infinity);
alert(9 * "\n9");
alert(null - 1);
alert("5" - 2);
alert("5px" - 3);
alert(true - 3);
alert(7 || 0);
//14
for(let i = 1, b = 0; i <= 10; i++){
  b=i;
  if(i % 2 == 0)alert(Number(b) + 2);
  else alert(i + "мм");
}
//15
let cicleNumb;
do{
  cicleNumb = prompt("Введите число меньше 100")
}while(cicleNumb < 100);
//16
let x = prompt("Введите день недели");

switch(Number(x)){
  case 1:
  alert("Пн");
  break;

  case 2:
  alert("Вт");
  break;

  case 3:
  alert("Ср");
  break;

  case 4:
  alert("Чт");
  break;

  case 5:
  alert("Пт");
  break;

  case 6:
  alert("Сб");
  break;

  case 7:
  alert("Вс");
  break;

  default:
  alert("Error");
}
