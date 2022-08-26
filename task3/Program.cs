// Напишите программу, которая 
// принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Please enter X coordinate of A");
int XA= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of A");
int YA= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter X coordinate of B");
int XB= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Y coordinate of B");
int YB= int.Parse(Console.ReadLine());
double distance=Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA));
Console.WriteLine($"Distance between A and B is {distance}");