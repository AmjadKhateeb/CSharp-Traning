using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    //Amjad Khateeb
    void Start()
    {

        int Multiply ( int num1 , int num2 ){
            int multi;
            multi = num1 * num2;

        return multi;
        }
        int result;
         for (int i =1; i<=10;i++){
            result = Multiply(5,i);
            Debug.Log("5 * " +i+ "= "+ result);

            
        }

        
        
    

}
}
