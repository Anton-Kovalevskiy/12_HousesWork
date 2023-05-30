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

void FindNumber (string message)
{
    Console.Write(message);
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите {M} чисел через пробел: ");
    string? arrayStr = Console.ReadLine();            // можно сразу: int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    string [] splitString = arrayStr.Split(' ');
    int [] array = new int [M];
    int number = 0;
    bool isNumber = true;
    for (int i = 0; i < M; i++)
    {
        isNumber = int.TryParse(splitString[i], out array[i]);
        if (isNumber == false)
        {
        break;    
        }
        if (array[i] > 0) number++;
    }
    if (splitString.Length != M) Console.Write("Введено неверное количество чисел!");
    else if (isNumber == false)  Console.Write("Один из введенных элементов не является числом!");
    else Console.WriteLine($"Количество введенных чисел больше нуля {number}.");
}


void Task41 (string task)
{
    Console.WriteLine($"Решение задачи №{task}");
    string message = "Введите количество чисел M = ";
    FindNumber (message); 
}

/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Решение 43

double [] equations (string message)
{
    Console.WriteLine(message);
    Console.Write("k1 -> ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 -> ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 -> ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 -> ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double [] dot = new double [2];
    if (k1 == k2) Console.WriteLine("Заданные прямые параллельны!");
    else
    {
    dot [0] = Math.Round((b2 - b1)/(k1 - k2), 2);
    dot [1] = Math.Round(k1 * dot [0] + b1, 2);
    Console.Write($"Точка пересечения двух прямых имеет координаты [{dot[0]}; {dot[1]}]");
    }
    return (dot);
}

void Task43(string task)
{
    Console.WriteLine($"Решение задачи №{task}");
    string message = "Прямые заданы уравнениями y=k1*x+b1 и y=k2*x+b2. Введите: ";
    double [] dot = equations(message);    
}
