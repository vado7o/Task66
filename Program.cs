// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.WriteLine("Программа выдаёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии");

int first = 0;
first = AskForInput("меньшее");
int second = AskForInput("большее");

System.Console.WriteLine("\nСумма всех натуральных чисел в промежутке от " + first + " до " + second + $": {PrintSumNumbers(first + 1, second)}");


//////////////////////////// функции ////////////////////////////////////////////////////


int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите {str} натуральное число интервала :");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number > first) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число интервала!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число интервала!\n");
    }
}

int PrintSumNumbers(int first, int second)
{
    return first == second - 1 ? first : PrintSumNumbers(first + 1, second) + first;
}

