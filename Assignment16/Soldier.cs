using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment_16
{

    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Debug.Log("Soldier");
        }


    }

}