using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Subhi{

public class GameManager : MonoBehaviour
{
    Player player1 = new Player();
    Player player2 = new Player();
    

    void Start() 
    {


    player1.InitializePlayer("Amjad", 80);
    player2.InitializePlayer("Mohammed", 90);

    player1.Heal(10);
    player1.Heal(true);

    Player.ShowPlayerCount();
    }
    
    
}
}
