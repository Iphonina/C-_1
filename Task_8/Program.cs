﻿// Задача 8. На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= N)
{
    Console.Write(count + ", ");
    count = count + 2;
}

