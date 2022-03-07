using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collison) 
   {
       if(collison)
       {
            Score.score++;
            FinalScore.finalScore = Score.score;
            
       }
       
   }
    
}
