// Урок 9. Как не нужно писать код. Часть 3
// -----------------------------------------------------Все решаем через рекурсию---------------------------------------------
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Task64(){
    Console.Clear();
    Console.WriteLine("Задача 64");
    Console.WriteLine("");

    int N = InputNumbers("Введите число N: ");

    Console.Write(PrintNumbers(N, 1));

    string PrintNumbers(int end, int start){
    if(start == end) return start.ToString();
    return (end + ", " + PrintNumbers(end - 1, start));
    }
}

void Task66(){
    Console.Clear();
    Console.WriteLine("Задача 66");
    Console.WriteLine("");

    int M = InputNumbers("Введите число M: ");
    int N = InputNumbers("Введите число N: ");

    void SumNumbers(int start, int end, int Sum){
    if (start > end){
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {Sum}"); 
        return;
        }
    Sum = Sum + (M++);
    SumNumbers(M, N, Sum);
    }
SumNumbers(M, N, 0);
}


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output;
}