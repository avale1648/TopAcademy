//1. Создать переменную «возраст» человека и определить, является ли он совершеннолетним.
var age = 19;
if(age >= 18)
    console.log('Adult');
else
    console.log('Not adult');
//2.Создать переменную «год» и проверить, високосный он или нет. Високосный год либо кратен 400, либо кратен 4 и при этом не кратен 100.
var year = 100;
if(year%4||(year%100==0&&year%400))
    console.log('Year is not leap');
else
    console.log("Year is leap");
//3.Создать  переменную «сумма покупки» и вывести сумму к оплате со скидкой: более 1000 – скидка 5%.
var amount = 2000;
if(amount > 1000)
    amount = amount - 5*amount/100;
console.log(amount);
//4.Создать две переменные : «длина окружности» и «периметр квадрата». Определить, может ли такая окружность поместиться в указанный квадрат.
var circumference = 7;
var squarePerimeter = 10;
if(circumference/3.14<squarePerimeter/4)
    console.log('Circle fits into a square');
else
    console.log('Circle does not fit into a square');