using System.Collections;
using System.Collections.Generic;
using Amajd;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player player = new Player("Amjad", 90);
        Enemy enemy = new Enemy("Sharshabel", 70);

        Debug.Log("The enemy health is " + enemy.Health);
        Debug.Log("The palyer health is " + player.Health);

        player.Heal(10);
        Debug.Log("Player health after Heal = " + player.Health);

        enemy.Attack(player, 50);
        Debug.Log("Player health after attack = " + player.Health);




    }

}
