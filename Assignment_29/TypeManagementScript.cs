using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assigment29;


public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");
    }

    public void Move()
    {
        Debug.Log("Animal moves.");
    }
}

public interface ICanFight
{
    void Attack();
}


public class Cat : Animal, ICanFight
{
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }

    public new void Move()
    {
        Debug.Log("Cat runs quickly.");
    }

    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }
}

public class Warrior : ICanFight
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }
}

public class TypeManagementScript : MonoBehaviour
{
    void Start()
    {

        Cat cat = new Cat();
        Animal animalRef = cat;

        animalRef.MakeSound();
        animalRef.Move();


        Cat downcastedCat = animalRef as Cat;
        if (downcastedCat != null)
        {
            downcastedCat.MakeSound();
            downcastedCat.Move();
        }

        // Type Checking with Interface
        List<ICanFight> fighters = new List<ICanFight>
        {
            new Cat(),
            new Warrior()
        };

        foreach (ICanFight fighter in fighters)
        {
            fighter.Attack();

            if (fighter is Cat)
            {
                Debug.Log("The object is a Cat.");
            }
            else if (fighter is Warrior)
            {
                Debug.Log("The object is a Warrior.");
            }
        }
    }
}

