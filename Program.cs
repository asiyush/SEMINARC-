// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Enter n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m:");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,]arr=new int [n, m];
// Random ran = new Random();
// for (int i=0; i<n; i++)
// {
//     for(int j=0; j<m; j++)
//     {
//         arr[i, j] = ran.Next(0, 100);

//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.ReadLine();


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Enter n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m:");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,]arr=new int [n, m];
// int []sum=new int [m];
// Random ran = new Random();

// for (int i=0; i<n; i++)
// {
//     for(int j=0; j<m; j++)
//     {
//         arr[i, j] = ran.Next(0, 100);

//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// for (int i=0; i<m; i++)
// {
//     for(int j=0; j<n; j++)
//     {
//         sum[i] += arr[j, i];
//     }
// }

// for (int i=0; i<m; i++)
// {
//     Console.Write((sum[i] / n)  + " ");
// }
// Console.ReadLine();


// //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// {Console.WriteLine("Enter n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m:");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,]arr=new int [n, m];
// Random ran = new Random();
// for (int i=0; i<n; i++)
// {
//     for(int j=0; j<m; j++)
//     {
//         arr[i, j] = ran.Next(0, 100);

//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.ReadLine();
//     Console.WriteLine("Введите координаты");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a>n && b>m)
//    { Console.WriteLine("такого числа нет");
//     return;
// }
//     else
//     {
//    int c = arr[a,b];
//     Console.WriteLine(c);
//     }
// }