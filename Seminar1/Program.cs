/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
int num1;
int num2;

Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else if (num1 < num2)
{
    Console.WriteLine("max = " + num2);
}
else
{
    Console.WriteLine("Числа равны");
}



*/
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/* 
int num1;
int num2;
int num3;

Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2)
{
    if (num1 >= num3)
    {
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine(num3);
    }
}
else
{
    if (num2 >= num3)
    {
        Console.WriteLine(num2);
    }
    else
    {
        Console.WriteLine(num3);
    }
}


 */
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
int num;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
int num;
int count = 2;
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

while (count <= num)
{
    Console.Write(count + ", ");
    count = count + 2;
}


*/



