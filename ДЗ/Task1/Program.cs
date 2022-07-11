// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


void PrintNatNub (int a, int b)
{
    if (a > b) return ;
    if ( b % 2 == 1)
    {b --;

    }
    PrintNatNub(a, b-2);
    Console.Write($"{b}; ");
}

int M = Prompt("Ведите первое число промежутка [M, N} => ");
int N = Prompt("Ведите первое число промежутка [M, N} => ");
PrintNatNub(M, N);