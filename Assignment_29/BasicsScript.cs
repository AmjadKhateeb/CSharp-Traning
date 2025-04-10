using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assigment29
{

    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            var number = 5;
            var name = "amjad";
            var isItWork = true;

            string result = number % 2 == 0 ? "even" : "odd";


            Debug.Log($"The number {number} is {result}.");


            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }


    }
}
