﻿//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 
// Console.Write("Введи N: ");
// int N = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи M: ");
// int M = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"N={N}, M={M}");
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");



// //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumFromMToN(m, n);
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }



//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите два положительных числа: M и N.");
// int m = InputInt("Введите M: ");
// int n = InputInt("Введите N: ");
// Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }
 
