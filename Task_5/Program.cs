﻿// на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;

while(count <= N)
{
    Console.Write(count);
    count = count + 1;
}

