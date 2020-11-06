using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
    }
 public void playgame(){
       SceneManager.LoadScene(0);
    }
}
