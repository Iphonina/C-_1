// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num%100)%10;
Console.Write(result);
