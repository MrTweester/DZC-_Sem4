//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int stepen = 0;
// for (int i=1; i<=b; i++)
// {
//     stepen = Math.Pow(a,2);
// }
// Console.Write(stepen+" ");


// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int power=0;
// for (int i = 1; i <= b; i++)
// {
//     power = Math.Pow(a, b);
// //    Console.WriteLine($"{a}^{b} = {(long)Math.Pow(a, b):N0}"); 
// }
// Console.WriteLine($"{power}"); 

Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = 1;
while (b>0)
{
stepen = stepen * a;
b = b - 1;
}
Console.Write($"Число A в степени В -> {stepen}");
