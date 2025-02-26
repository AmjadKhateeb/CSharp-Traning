using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment26;
//Amjad Khateeb

public class CreatureManager : Creature
{

    void Start()
    {
        Kangaroo kangaroo = new Kangaroo();
        Duck duck = new Duck();
        List<Creature> creatureList = new List<Creature> { kangaroo, duck };
        List<IRunnable> runList = new List<IRunnable>();
        List<IJumpable> jumpList = new List<IJumpable>();
        List<ISwimmable> swimList = new List<ISwimmable>();

        runList.Add(kangaroo);
        jumpList.Add(kangaroo);

        runList.Add(duck);
        swimList.Add(duck);

        foreach (Creature creat in creatureList)
        {
            Speak();

        }
        foreach (IRunnable run in runList)
        {
            run.Run();
        }
        foreach (IJumpable jump in jumpList)
        {
            jump.Jump();
        }
        foreach (ISwimmable swim in swimList)
        {
            swim.Swim();

        }





    }

}
