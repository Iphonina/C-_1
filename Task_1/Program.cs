// На входe два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numB= Convert.ToInt32(Console.ReadLine());

int result = numB * numB;

if(result == numA)
{
    Console.Write("Да");
}
else
    Console.Write("Нет");
    