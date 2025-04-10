using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment35;


public class DerivedClassExample : AbstractBaseClass
{

    public override void PerformAction()
    {
        Debug.Log("PerformAction is implemented in the derived class.");
    }
}
