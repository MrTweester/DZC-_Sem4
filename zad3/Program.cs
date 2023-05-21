// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rand = new Random();
for (int i=0; i<arr.Length; i++)
{
    arr[i] = rand.Next(1, 100);
    Console.Write($"{arr[i]} ");
}