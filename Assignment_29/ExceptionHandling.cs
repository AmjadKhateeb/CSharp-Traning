using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;

public class ExceptionHandling : MonoBehaviour
{
    void Start()
    {
        int playerScore = 100;
        int diviser = 0; 
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser; 
            Debug.Log($"Total Score: {totalScore}");
        }
        catch (System.DivideByZeroException)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }
}
