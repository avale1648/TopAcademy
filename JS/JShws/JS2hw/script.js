var option = prompt('1. First Task;\n2. Second Task; \n3. Third Task; \n4. Fourth Task.','');
switch(option)
{   
//Задание  1:
//Задать пользователю 3 вопроса, в каждом вопросе по 3 варианта ответа.
//За каждый правильный ответ начисляется 2 балла. После вопросов выведите пользователю количество набранных баллов.
    case '1':
        {
            var points = 0;
            var result = prompt('?\n1.\n2;\n3.', '');
            if(result == 1)
                points = points + 2;
            var result = prompt('?\n4.\n5;\n6.', '');
                if(result == 4)
            points = points + 2;
                var result = prompt('?\n7.\n8;\n9.', '');
            if(result == 7)
                points = points + 2;
            alert('You\'ve reached ' + points + ' points.');
            break;
        }
//Задание  2:
//Запросить у пользователя его возраст и определить, кем он является: ребенком (0–2), подростком (12–18), взрослым (18_60) или пенсионером (60– ...).
    case '2':
        {
            var age = prompt('Please, enter your age:','');
            if (age >= 0 && age <= 2)
                alert('You\'re a baby.');
            else if(age >= 3 && age <= 12)
                alert('You\'re a child');
            else if(age >= 13 && age <= 17)
                alert('You\'re a teenager.');
            else if(age >= 18 && age <= 59)
                alert('You\'re an adult.');
            else
                alert('You\'re an old person.');
            break;
        }
//Задание  3:
//Зациклить калькулятор. Запросить у пользователя 2 числа и знак, решить пример, вывести результат и спросить, хочет ли он решить еще один пример. 
//И так до тех пор, пока пользователь не откажется.
    case '3':
        {
            while(true)
            {
                var x = Number(prompt("First number:",0));
                var y = Number(prompt("Second number:",0));
                var action = prompt("Action:");
                switch(action)
                {
                    case '+':
                        x = x + y;
                    break;
                    case '-':
                        x = x - y;
                    break;
                    case '*':
                        x = x * y
                    break;
                    case '/':
                        x = x / y;
                    break;
                    default:
                        x = 'error';
                    break;
                }
                if(!confirm('Result is ' + x + '. Would you like to calculate anything other?'))
                {
                    break;
                }
            }
            break;
        }
        //Задание  4:
//Запросить у пользователя 10 чисел и подсчитать, сколько он ввел положительных, отрицательных и нулей. При этом также посчитать, сколько четных и нечетных. 
//Вывести статистику на экран. Учтите, что достаточно одной переменной (не 10) для ввода чисел пользователем.
    case '4':
        {
            var positives = 0, negatives = 0, nulls = 0, evens = 0, odds = 0;
            for(var i = 0; i < 10; i++)
            {
                var number = Number(prompt("Enter the number:"));
                if(number > 0)
                    positives++;
                if(number < 0)
                    negatives++;
                if(number == 0)
                    nulls++;
                if(number % 2 == 0)
                    evens++;
                if(number % 2 == 0)
                    odds++;
            }
            alert('Positive numbers: ' + positives + '\nNegative numbers: ' + negatives + '\nNulls: ' + nulls + '\nEven numbers: ' + evens + '\nOdd numbers: ' + odds);
            break;
        }
       
}
