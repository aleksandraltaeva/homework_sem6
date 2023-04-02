// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
string[] mas = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Количество чисел больше нуля: {CountNumber(mas)}");

//-------метод подсчет чисел больше 0------
int CountNumber(string[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i])>0) count++;
    }
    return count;
}