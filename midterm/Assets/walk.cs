using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    
    static AudioSource audioSource;
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }


    public static void PlaySound (){
        audioSource.Play();
        
    }

    public static void stopSound(){
        audioSource.Stop();
    }
}
