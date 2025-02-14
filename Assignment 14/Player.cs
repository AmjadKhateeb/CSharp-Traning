using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Amajd
{

    public class Player : Character
    {


        // becuase  Character constructor requires arguments i need to add this line
        //ther is no need for   base(name, health) if Character is parameterless constructor
        public Player(string name, int health) : base(name, health) { }


        public void Heal(int amount)
        {
            Health = Health + amount;

        }

    }
}