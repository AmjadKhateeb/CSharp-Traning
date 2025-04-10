using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;

public class Recursion : MonoBehaviour
{
    void Start()
    {
        int n1 = 10;
        int n2 = 30;


        Debug.Log($"FibonacciRecursive({n1}) = {FibonacciRecursive(n1)}");
        Debug.Log($"FibonacciRecursive({n2}) = {FibonacciRecursive(n2)}");


        Debug.Log($"FibonacciIterative({n1}) = {FibonacciIterative(n1)}");
        Debug.Log($"FibonacciIterative({n2}) = {FibonacciIterative(n2)}");
    }

    int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int pre = 0, curr = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = curr;
            curr = curr + pre;
            pre = temp;
        }
        return curr;
    }
}
