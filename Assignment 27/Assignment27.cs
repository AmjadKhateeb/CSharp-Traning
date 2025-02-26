using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{

    public class Assignment27 : MonoBehaviour
    {

        void Start()
        {
            int Fvalue, Svalue;
            Fvalue = 1;
            Svalue = 2;
            CallByValue(Fvalue);
            Debug.Log(Fvalue);// will not Change


            CallByRef(ref Svalue); 
            Debug.Log(Svalue); //will Change

            int outVar;
            CallUsingOut( out outVar);
            Debug.Log(outVar); // will get the function value




        }

        void CallByValue(int num)
        {
            num += 10;
        }
        void CallByRef(ref int num)
        {
            num += 20;

        }
        void CallUsingOut(out int num){
            num = 50;
        }


    }
}