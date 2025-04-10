using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment35
{

    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {

            int health = 100;


            object boxedHealth = health;


            int unboxedHealth = (int)boxedHealth;
            unboxedHealth += 50;


            Debug.Log("Original int value (health): " + health);
            Debug.Log("Boxed value (boxedHealth): " + boxedHealth);
            Debug.Log("Unboxed and modified value (unboxedHealth): " + unboxedHealth);
        }
    }
}
