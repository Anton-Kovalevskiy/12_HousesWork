Console.Write("Введите номер задачи: ");
string? task = Console.ReadLine();
switch (task)
{
    case "41":
    Task41(task);
    break;
    case "43":
    Task43(task);
    break;
    default:
    break;
}
/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

// Решение 41

int [] FillArrayAndPrint (string message)
{
    Console.Write(message);
    string? arrayStr = Console.ReadLine();
    string[] splitString = arrayStr.Split(' ');
    int [] array = new int [splitString.Length];
    int m = array.Length;
    Console.Write($"Получен массив из {m} чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        int.TryParse(splitString[i], out array[i]);
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
    return (array);
}

int FindNumberOfPositive (int [] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) n++; 
    }
    return (n);
}

void Task41 (string task)
{
string message = "Введите числа массива через пробел: ";
int [] array = FillArrayAndPrint(message);
int number = FindNumberOfPositive(array);
Console.Write($"Количество чисел больше нуля равно {number}");
}


/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Решение 43


void Task43(string task)
{
    
}

//int[] array = new int[3];
//Console.Write("Enter the matrix in one line: ");
//int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

