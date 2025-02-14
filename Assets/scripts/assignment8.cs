using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
         int counter = 0;
         while (counter <20){
            int random = Random.Range(1,21);
            Debug.Log(random );
            if (random == 5)
            continue;
                else if (random == 15)
            break;
            counter++;

         }
         int wordCount  =0;
         string funnyWords =" ";
         string[] words = new string [10]{"Cat", "Dog","Car","Pizza","Hat","Fish","Tree",
         "Monkey","Ball","Bird"};
         while (wordCount  < 7){
            int randomWord = Random.Range(1,10);

            funnyWords =funnyWords+" " + words[randomWord];
           
            wordCount++;
           
         }
         Debug.Log(funnyWords);
         //Amjad Khateeb

    }

    
}
