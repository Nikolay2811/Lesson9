// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int M = Prompt("Ведите первое число промежутка [M, N} => ");
int N = Prompt("Ведите первое число промежутка [M, N} => ");

int PrintNatSum (int a, int b)
{
    if (a > b) return 0 ;
  
    return PrintNatSum(a, b-1)+b;
}

int sum =PrintNatSum(M, N);
Console.WriteLine($"Произведение натуральных чисел равно {sum}");