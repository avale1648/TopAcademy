function formatize()
{
    let json = document.getElementById("input");
    console.log(json);
    let value = json.value;
    if(isObject(json) == true)
    {
        value = JSON.stringify(json,null,4);
    }
    else
    {
        value = "Error: input isn't in JSON format...";
    }
    value = document.createTextNode(value);
    let out = document.getElementById("out")
    out.appendChild(value);
}
function isObject(obj)
{
    return obj !== undefined && obj !== null && obj.constructor == Object;
}