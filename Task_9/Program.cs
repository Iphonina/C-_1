// Задача 4. Ввести три числа и найти максимальное
Console.Write("Введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numB= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numC= Convert.ToInt32(Console.ReadLine());
int max = 0;

if((numA > numB) && (numA > numC))
    {
        max = numA;
    }
else if((numB > numA) && (numB > numC))
    {
        max = numB;
    }
else if((numC > numA) && (numC > numB))
    {
        max = numC;
    }

Console.Write("max = ");
Console.WriteLine(max);

