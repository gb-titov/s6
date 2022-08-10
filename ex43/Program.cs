//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using ex43;


Console.Clear();
Console.WriteLine("Программа для нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

double b1 = GetUserInputAsDouble("Введите b1");
double k1 = GetUserInputAsDouble("Введите k1");
double b2 = GetUserInputAsDouble("Введите b2");
double k2 = GetUserInputAsDouble("Введите k2");


Point point = FindIntersection(k1, b1, k2, b2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {point} ");



#region Methods

Point FindIntersection(double k1, double b1, double k2, double b2)
{
    //k1*x+b1 - (k2*x+b2) = (k1-k2)x + b1 - b2 = (k1-k2)x = -b1 + b2 = (-b1 + b2) / (k1 - k2)
    double x = (-b1 + b2) / (k1 - k2);
    double y = k1 * x + b1;
    return new Point(x, y);
}

double GetUserInputAsDouble(string msg)
{
    Console.Write($"{msg}: ");
    if (!double.TryParse(Console.ReadLine(), out double result))
    {
        Console.WriteLine("Неверный ввод! Попробуйте снова.");
        GetUserInputAsDouble(msg);
    }
    return result;
}

#endregion
