using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knocksound : MonoBehaviour
{
    public static  AudioClip knockSound;
    static AudioSource audioSource;
    void Start()
    {
        knockSound = Resources.Load<AudioClip>("knocks");
        audioSource = GetComponent<AudioSource>();
    }

   public static void PlaySound (){
        audioSource.PlayOneShot(knockSound);
    }
}
