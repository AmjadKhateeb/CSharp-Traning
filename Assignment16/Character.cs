using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Assignment_16
{

    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float x, float y, float z)
        {

            X = x;
            Y = y;
            Z = z;


        }
        public void PrintPosition()
        {
            Debug.Log("The Position is : " + X + Y + Z);

        }

    }
    public class Character
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100)
                    health = 100;
                else if (value < 0)
                    health = 0;
                else health = value;
            }

        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;

        }
        public Character() : this("no name", 100, new Position(0, 0, 0)) { }
         public virtual void DisplayInfo()
        {
            Debug.Log("the name is :" + name);
            Debug.Log("the Health is :" + Health);

            position.PrintPosition();


        }
        public void Attack(int damage, Character target)
        {
            target.health = health - damage;

        }
        public void Attack(int damage, Character target, string attckType)
        {
            target.health = health - damage;
            Debug.Log(" The atttack type is :" + attckType);

        }



    }







}