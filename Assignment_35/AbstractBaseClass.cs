using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment35;

public abstract class AbstractBaseClass : MonoBehaviour
{

    public abstract void PerformAction();

    public void PrintInfo()
    {
        Debug.Log("This is a concrete method in the abstract base class.");
    }
}
