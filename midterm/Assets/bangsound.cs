using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bangsound : MonoBehaviour
{
  
    static AudioSource audioSource;
    public static  AudioClip bangSound;
    void Start()
    {
        bangSound = Resources.Load<AudioClip>("Bang");
        
        audioSource = GetComponent<AudioSource>();
    }

   public static void PlaySound (){
        audioSource.PlayOneShot(bangSound);
    }
   

}


