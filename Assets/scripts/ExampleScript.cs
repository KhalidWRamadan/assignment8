using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //Exercise 1
      int count = 0;
      while(count < 20){
       count++;
       int randomNumber = Random.Range(1, 21);
       if (randomNumber == 5) continue;
       else if (randomNumber == 15) break;
       Debug.Log(randomNumber);
      }

      //Exercise 2
      string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
      int count2 = 0;
      string funnySentence = "";
      while(count2 < 7){
        int randomIndex = Random.Range(0, words.Length);
        funnySentence += words[randomIndex];
        count2++;
      }
      Debug.Log(funnySentence);
     
    }

   
}
