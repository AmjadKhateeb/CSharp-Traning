using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public static class Utilities
{
    // Static method using params
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static string RepeatString(this string str, int count)
    {
        if (string.IsNullOrEmpty(str) || count <= 0)
            return "";

        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += str;
        }
        return result;
    }

}

