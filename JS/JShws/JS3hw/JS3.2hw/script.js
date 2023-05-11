function changeColor()
{
    let whatToPaint = document.getElementById(figure.value);
    figure.value=="triangle"? whatToPaint.style.borderBottomColor = color.value: whatToPaint.style.backgroundColor = color.value;
}
function rotate()
{
    let whatToRotate = document.getElementById(figure.value);
    if(angle.value == 0)
        whatToRotate.style.transform = 'rotate(0deg)';
    if(angle.value == 45)
        whatToRotate.style.transform = 'rotate(45deg)';
    if(angle.value == 90)
        whatToRotate.style.transform = 'rotate(90deg)';
    if(angle.value == 180)
        whatToRotate.style.transform = 'rotate(180deg)';
}