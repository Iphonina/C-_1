// Задача 2. Ввод двух чисел и показать какое из них большее, а какое меньшее
Console.Write("Введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numB= Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.Write("max = ");
    Console.WriteLine(numA);
    Console.Write("min = ");
    Console.WriteLine(numB);
}
else
    Console.Write("max = ");
    Console.WriteLine(numB);
    Console.Write("min = ");
    Console.WriteLine(numA);

