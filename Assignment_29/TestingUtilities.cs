using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;


public class TestingUtilities : MonoBehaviour
{
    void Start()
    {

        int sum = Utilities.Add(1, 2, 3, 4, 5);
        Debug.Log($"Sum: {sum}");

        string message = "Hello";
        Debug.Log(message.RepeatString(3));
    }
}

