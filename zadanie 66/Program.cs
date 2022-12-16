﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int num1, int num2)
{
    if(num1==num2)
    {
        return num2;
    }
    return(num1 + GetSum(num1+1, num2));
}

System.Console.WriteLine(GetSum(1, 3));