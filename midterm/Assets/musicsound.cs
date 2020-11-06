using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicsound : MonoBehaviour
{
    public static  AudioClip musicSound;
     
    static AudioSource audioSource;
    void Update()
    {
        string s = knock.song();
        musicSound = Resources.Load<AudioClip>(s);
        Debug.Log(s);
        audioSource = GetComponent<AudioSource>();
    }

   public static void PlaySound (){
        audioSource.PlayOneShot(musicSound);
    }


     public static void stopSound(){
        audioSource.Stop();
    }
}
