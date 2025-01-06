using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using Assignment_18;
public class Inventory
{
    private List<string> items;

    public Inventory()
    {
        items = new List<string>();
    }

    public void AddItem( string item){

        items.Add(item);

    }
    public void Showitems(){
        for (int i=0; i<items.Count;i++){
            Debug.Log(items[i]);

        }
    }
    public static Inventory operator + (Inventory a , Inventory b){
        Inventory compinedInv = new Inventory();
        foreach (string n in a.items){
            compinedInv.AddItem(n);

        }
        foreach (string n in b.items){
            compinedInv.AddItem(n);

        }
        return compinedInv;
    }
    }
