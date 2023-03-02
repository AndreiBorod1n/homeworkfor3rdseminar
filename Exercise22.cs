// 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine()); // Array Length
int[] arr = new int[N];
int power = 3;
for (int index = 0; index < N; index++)
{
    arr[index] = index + 1;
    arr[index] = Convert.ToInt32(Math.Pow(arr[index], power));
    System.Console.Write(arr[index]);
    Console.Write(' ');
}