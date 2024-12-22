using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment_16;

public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Soldier soldier = new Soldier("Amjad", 90,new Position (1,2,3));
        Officer officer = new Officer("sobhi", 80,new Position (2,3,5));
        Character[] players= {soldier , officer}; 

        for (int i =0; i<players.Length;i++){
            players[i].DisplayInfo();

            Debug.Log("before the Attack");
            soldier.DisplayInfo();

            officer.Attack(20, soldier);

            Debug.Log("after the Attack");
            soldier.DisplayInfo();



        }

    }


}
