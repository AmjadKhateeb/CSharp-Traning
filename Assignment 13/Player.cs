using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Subhi {

 public class Player 
{
    public string playerName ;
    public int health;
    static public int playerCount = 0;

    public void InitializePlayer(string name,int initialHealth) {
        playerName =name;
        initialHealth = health;
        playerCount++;

    }
    public void Heal (int amount){
        health += amount;
        Debug.Log(health);
    }
    public void Heal(bool fullRestore = false){
        if (fullRestore == true){
            health = 100;
        }

    }
    static public void ShowPlayerCount(){
        Debug.Log(playerCount);
    }
   
}}
