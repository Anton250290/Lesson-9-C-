﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int n = InputNumber("Введите число N: ");
int count = 2;

void PrintNumber(int n, int count)
{
    if (count > n) 
    return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

PrintNumber(n, count);
Console.Write(1);