// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Write("Введите число в диапазоне от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.Write("понедельник");
}
else if(number == 2)
{
    Console.Write("вторник");
}
else if(number == 3)
{
    Console.Write("среда");
}
else if(number == 4)
{
    Console.Write("четверг");
}
else if(number == 5)
{
    Console.Write("пятница");
}
else if(number == 6)
{
    Console.Write("суббота");
}
else if(number == 7)
{
    Console.Write("воскресенье");
}
else
{
    Console.Write("Такого дня нет");
}