using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playgame(){
       SceneManager.LoadScene(1);
    }

     AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public  void PlaySound (){
        audioSource.Play();
        
    }

    public void stopSound(){
        audioSource.Stop();
    }
}

