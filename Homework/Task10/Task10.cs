﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int n = new Random().Next(100, 1000); // эти две строчки просто выводят случайное число
//
// System.Console.WriteLine(n);
//
// System.Console.WriteLine((n / 10) % 10);

// Вариант решения от препода
int n = 531;
System.Console.WriteLine(n / 10 % 10); // n/10 - число перестанет быть трехзначным 531 = 53, а потом мы 53 % 10, остаток от деления = 3