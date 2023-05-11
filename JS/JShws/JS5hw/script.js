//1. Navigator:
document.write('1. Navigator:<br><br>');
var browser = 'Unknown Browser', userAgent = navigator.userAgent;
if(userAgent.indexOf("Chrome") > -1) {
    browser = "Google Chrome";
} else if (userAgent.indexOf("Safari") > -1) {
    browser = "Apple Safari";
} else if (userAgent.indexOf("Opera") > -1) {
    browser = "Opera";
} else if (userAgent.indexOf("Firefox") > -1) {
    browser = "Mozilla Firefox";
} else if (userAgent.indexOf("MSIE") > -1) {
    browser = "Microsoft Internet Explorer";
}
document.write(browser);
navigator.geolocation.getCurrentPosition(sucess,error);
function sucess(position)
{
    document.write('Местоположение:<br/>Широта:' + position.coords.latitude +';<br/>Долгота: ' + position.coords.longitude + '.<br/>');
}
function error(obj)
{
    document.write('Не удалось определить местоположение...</br>');
}
//2. Screen
document.write('2. Screen:<br>');
document.write('<br>Глубина цвета: ' + screen.colorDepth + '<br>Ориентация: '
+ screen.orientation.angle + '<br>Высота: '+ screen.height + '<br>Ширина: ' + screen.width + '<br>');
//3. History
document.write('3. History:<br>');
document.write('Страниц в истории: ' + history.length);
while(true)
{
    let option = prompt('Введите кол-во страниц, на которое нужно переместиться в истории (положительные числа - перемещение вперед, отрицательные - назад, нуль - выход): ','');
    if(option == 0)
        break;
    else if(parseInt(option) != 0)
        history.go(option);
    else
        alert('Ошибка...');
}
//4. Local Storage
document.write('<br>4. Local Storage:<br>')
var login = 'mirand';
localStorage.setItem("login", login);
document.write('<br> Логин: ' + localStorage.getItem("login"));