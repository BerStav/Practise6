// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Please enter the b1 number: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Please enter the k1 number: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Please enter the b2 number: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Please enter the k2 number: ");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

 Console.WriteLine($"Two lines intersect at a point with coordinates ({x}, {y})");