// Написать программу, которая на вход принимает число и выдает квадрат этого числа (возводит в степень)
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Результат {result}");

if(number == result)
{
    Console.WriteLine($"Не может такого быть!");
}
else
{
   Console.WriteLine($"Да");
}




