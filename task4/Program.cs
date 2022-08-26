// Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Please enter N");
int N= int.Parse(Console.ReadLine());
int c=1;
while (c<=N)
{
    double result=Math.Pow(c,2);
    Console.WriteLine($"{N} result is {result}");
    c=c+1;
}