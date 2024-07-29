using System;
using System.Collections.Generic;


public static class Kata
{
    static Dictionary<int, string> weekdays = new Dictionary<int, string>()
    {
        { 1, "Sunday" },
        { 2, "Monday" },
        { 3, "Tuesday" },
        { 4, "Wednesday" },
        { 5, "Thursday" },
        { 6, "Friday" },
        { 7, "Saturday" },
    };

    public static string WhatDay(int n)
    {
        if (n < 1 || n > 7)
        {
            return "Wrong, please enter a number between 1 and 7";
        }
        return weekdays[n];
    }
}

