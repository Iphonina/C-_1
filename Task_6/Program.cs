// Задача 6. Вводим число и узнаем четное оно или нет
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.Write("это число четное");
}
else
    Console.Write("это число нечетное");
