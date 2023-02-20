// ЭТО НЕ ДОМАШНЕЕ ЗАДАНИЕ


//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.


//Console.WriteLine("Введите число 1: ");
//int x = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите число 2: ");
//int y = int.Parse(Console.ReadLine()!);
//int sqr = y *y;
//if (x == sqr)
//{
//    Console.WriteLine("Первое число является квадратом второго");
//}
//
// else
// {
//    Console.WriteLine("Первое число не равно квадрату второго числа");
// }


//№3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

//Console.WriteLine("Введите номер для вывода определенного дня недели, от 1 до 7");
//int number = int.Parse(Console.ReadLine()!);
//
//if (number == 1)
//{
//    Console.WriteLine("Понедельник");
//}
//
//if (number == 2)
//{
//    Console.WriteLine("Вторник");
//}
//
//if (number == 3)
//{
//    Console.WriteLine("Среда");
//}
//
//if (number == 4)
//{
//    Console.WriteLine("Четверг");
//}
//if (number == 5)
//{
//    Console.WriteLine("Пятница");
//}
//
//if (number == 6)
//{
//    Console.WriteLine("Суббота");
//}
//if (number == 7)
//{
//    Console.WriteLine("Воскресенье");
//}


//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

//Console.WriteLine("Введите число");
//int number = int.Parse(Console.ReadLine()!);
//for(int i = -number; i <= number; i++);
//{
//    System.Console.WriteLine(i);
//}


//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8


//Console.Write("Введите трехзначное число: ");
//int number = int.Parse(Console.ReadLine()!);
//if(number < 99 && number > 1000 )
//{
//    number = number % 10 ;
//    Console.WriteLine($"Крайнее число: {number}");
//}

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

// if (numberB > max && numberB < numberA)
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
// if (numberA > max)




