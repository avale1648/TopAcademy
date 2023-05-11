//let name = 'Bob';
//let value = 'Ivanov';
//document.cookie = encodeURIComponent(name) + '=' + encodeURIComponent(value);
//let date = new Date(Date.now()+60);
//date = date.toUTCString();
//document.cookie = "user=Ivan; expires" + date;
//document.cookie = "user=Ivan; secure";
//alert(document.cookie);
function checkReg()
{
    let x = document.cookie;
    let rd = document.getElementById("reg");
    let s = x.split(';');
    let cookieObject = {};
    let c;
    for(let i = 0; i < s.length; i++)
    {
        c = s[i].split('=');
        cookieObject[c[0]] = c[1];
    }
    if('register' in cookieObject)
    {
        rd.innerHTML = "Hello, " + cookieObject[`register`];
    }
    else
    {
        rd.innerHTML = "Name <input type='text' id='name'/><input type='button' value='Register'onclick='regClick()'/>";
    }
}
function regClick()
{
    let inputName = document.getElementById("name");
    name = inputName.value;
    let expDate = new Date;
    expDate.setTime((new Date).getTime()+60*1000);
    document.cookie="register="+name+";expires="+expDate.toGMTString()+";path=/";
    checkReg();
}