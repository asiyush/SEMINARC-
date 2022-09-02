// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num_a; 
int num_b;

Console.Write("Введите числа: ");

num_a = Convert.ToInt32(Console.ReadLine());
num_b = Convert.ToInt32(Console.ReadLine());

if (num_a > num_b){
    Console.WriteLine("Большее число " + num_a); 
}
else{
    Console.WriteLine("Большее число: " + num_b);
}



//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num_a; 
int num_b;
int num_c;
int max;

Console.Write("Введите числа: ");

num_a = Convert.ToInt32(Console.ReadLine());
num_b = Convert.ToInt32(Console.ReadLine());
num_c = Convert.ToInt32(Console.ReadLine());

max = num_a;

if (num_b > num_a)
    max = num_b;
if (num_c > max)
    max = num_c;
    {
    Console.WriteLine("максимальное число " + max); 
}



//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num; 

Console.Write("Введите число: ");

num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    {
    Console.WriteLine(" Да "); 
}
else{
    Console.WriteLine(" Нет ");
}



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num; 

Console.Write("Введите число: ");

num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num){
    if (current % 2 == 0)
    {
    Console.WriteLine(current + " ");}
    current++;
    }
