﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine()!);
// int max = 0;
// if (numberA > max && numberB < numberA)
// {
//     max = numberA;
//     Console.Write("max = ");
//     Console.WriteLine(max);
// }

// if (numberB > max && numberB > numberA)
// {
//     max = numberB;
//     Console.Write("max = ");
//     Console.WriteLine(max);
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int numberC = int.Parse(Console.ReadLine()!);
// int max = 0;

// if (numberA > max && numberA > numberB && numberA > numberC)
// {
//     max = numberA;
//     Console.Write("max = ");
//     Console.WriteLine(max);
// }

// if(numberB >  max && numberB > numberA && numberB > numberC)
// {
//      max = numberB;
//     Console.Write("max = ");
//     Console.WriteLine(max);
// }

// if (numberC > max && numberC > numberA && numberC > numberB)
// {
//     max = numberC;
//     Console.Write("max = ");
//     Console.WriteLine(max);
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number % 2 == 0)
// {
//     Console.WriteLine("Да");
// }

// else
// {
//      Console.WriteLine("Нет");
// } 

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int newNumber = 1;
// while (newNumber <= number)
// {
//     if (newNumber % 2 == 0)
//     {
//         Console.WriteLine("+" + newNumber);
//     }
//     newNumber++;
// }