﻿//Напишите программу,которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");
        int number = int.Parse(Console.ReadLine());

        int secondDigit = (number / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    