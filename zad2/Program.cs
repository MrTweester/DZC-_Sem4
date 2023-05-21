//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Length(int a)
{
int i = 0;
while (a > 0)
{
a /= 10;
i++;
}
return i;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int lenght = Length(num);
Console.Write($"Сумма цифр в числе {num} равно: {Sum(num,lenght)}");

