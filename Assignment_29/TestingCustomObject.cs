using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;

public class TestingCustomObject : MonoBehaviour
{
    void Start()
    {

        CustomObject obj1 = new CustomObject(1, "Example");
        Debug.Log(obj1);


        CustomObject obj2 = new CustomObject(1, "Example");

        Debug.Log($"obj1 == obj2: {obj1 == obj2}");
        Debug.Log($"obj1 != obj2: {obj1 != obj2}");
    }
}

