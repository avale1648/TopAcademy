function change_color(_color, _figure)
{
    let color = document.getElementById(_figure.value);
    function func_color(_col, _fig)

    {
    
        let color=document.getElementById(_fig.value);
    
         _fig.value=="triangle"?color.style.borderBottomColor=_col.value: "square"?color.style.borderBottomColor=_col.value: color.style.backgroundColor=_col.value;
    
    }
    
}