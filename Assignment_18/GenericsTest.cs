using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment_18;

public class GenericsTest : MonoBehaviour
{

    void Start()
    {
        GameContainer<string> GameString = new GameContainer<string>();
        GameString.SetItem("Health Potion");
        string savedItem = GameString.GetItem();

        string desc = GameUtils.DescribeItem(GameString.GetItem());
        Debug.Log(savedItem);
        Debug.Log(desc);

    }


}
