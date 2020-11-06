using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioscript : MonoBehaviour
{
     bool ison;
    void Update()
    {
    
        if(knock.grabradio() && ison == false){
            ison = true;
            musicsound.PlaySound();
        }
    }

  



     void OnMouseDown(){
         if(ison){
         musicsound.stopSound();
         knock.setradio(false);
         knock.increaseCounter();
         ison = false;
         }
        
     }
}
