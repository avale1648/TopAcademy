class Student
{
    firstname;
    lastname;
    gender;
    age;
    gpa;
    constructor(firstname_, lastname_, gender_, age_, gpa_)
    {
        this.firstname = firstname_;
        this.lastname = lastname_;
        this.gender = gender_;
        this.age = age_;
        this.gpa = gpa_;
    }
}
    let group = 
    [
        new Student("Ангелина", "Гришутина", "female", 17, 12),
        new Student("Алексей", "Смахтин", "male", 23, 11),
        new Student("Артем", "Пустовой", "male", 25, 10),
        new Student("Максим","Корнильев","male", 22, 9),
        new Student("Кирилл","Щербаков","male", 17, 8),
        new Student("Михаил","Маськов","male", 25, 7),
        new Student("Константин","Киселев","male", 22, 6),
        new Student("Анна", "Ерошина", "female", 30, 10),
        new Student("Артем", "Воробьев", "male", 17, 6),
        new Student("Никита", "Бурыкин", "male", 17, 7),
        new Student("Олег", "Медведев", "male", 17, 10),
        new Student("Андрей", "Миронов", "male", 22, 10),
        new Student("Мурад", "Резван", "male", 22, 12),
    ];
    var exit = false;
    while(!exit)
    {
        let option = prompt('1. Вся группа;\n2. Старше двадцати лет; \n3. Средний бал меньше семи; \n4. Количество мужчин и женщин;\n5. Средний балл в группе;\nEnter. Выход.','');
        let info ='';
        switch(option)
        {   
            case '1':
                group.forEach(student => info += `${student.firstname}, ${student.lastname}, ${student.age}, ${student.gpa}\n`);
            break;
            case '2':
                var count = 0;
                for(i = 0; i < group.length; i++)
                {
                    if(group[i].age >= 20)
                    {
                        count++;
                        info += `${group[i].firstname}, ${group[i].lastname}, ${group[i].age}, ${group[i].gpa}\n`;
                    }
                }
                info += `\nКоличество: ${count}`;
                break;
            case '3':
                var count = 0;
                for(i = 0; i < group.length; i++)
                {
                    if(group[i].gpa < 7)
                    {
                        count++;
                        info += `${group[i].firstname}, ${group[i].lastname}, ${group[i].age}, ${group[i].gpa}\n`;
                    }
                }
                info += `\nКоличество: ${count}`;
                break;
            case '4':
                var men = 0, women = 0;
                for(i = 0; i < group.length; i++)
                {
                    if(group[i].gender == "male")
                        men++;
                    else
                        women++;
                }
                info = `Мужчин: ${men}\nЖенщин: ${women}`;
            break;
            case '5':
                var groupGpa = 0;
                for(i = 0; i < group.length; i++)
                {
                    groupGpa += Number(group[i].gpa);
                }
                info = `Средний балл в группе: ${groupGpa/group.length}`;
            break;
            case '':
                exit = true;
                info = "Выход";
            break;
            default:
                info = "Ошибка";
            break;
        }
        alert(info);
    }

