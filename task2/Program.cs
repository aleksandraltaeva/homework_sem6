// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
// k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = Input("Введите значение b1: ");
double k1 = Input("Введите значение k1: ");
double b2 = Input("Введите значение b2: ");
double k2 = Input("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения двух прямых: x = {Math.Round(x,2)}, y = {Math.Round(y,2)}");

//------метод: приглашение ко вводу числа------
double Input(string text)
{
    Console.Write(text);
    double num = int.Parse(Console.ReadLine()!);
    return num;
}

