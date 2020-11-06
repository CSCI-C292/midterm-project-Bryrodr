using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class knock : MonoBehaviour
{
    [SerializeField] GameObject door;
   
  
  static int counter = 0;
  static bool radiocondition = false;
  void OnMouseDown(){
      knocksound.PlaySound();
      setradio(true);
  }


public static void setradio(bool hi){
  radiocondition = hi;
}

public static bool grabradio(){
  return radiocondition;
}

void Update(){
  if(counter ==3){
    openDoor2();
  }
}

public static void increaseCounter(){
  counter++;
  
}

public static int getCounter(){
  return counter;
}

public void openDoor2(){ 
  
  bangsound.PlaySound();
  GameObject.Destroy(door);
  
}
  public static bool startMovement(){
    if(counter == 3){
      return true;
    }
    else{
      return false;
    }
  }


public static string song(){
  if(counter == 0){
    return "tiptoev1";
  }
  if(counter == 1){
    return "tiptoev2";
  }
   else{
    return "tiptoev3";
  }
}



}