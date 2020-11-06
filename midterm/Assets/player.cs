using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField]float _mouseSensitivity = 10f;
    [SerializeField] float _movespeed = 300f;

    [SerializeField] Camera _cam;

    bool iswalking = false;

    float _currentTilt = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
   void Update()
    {
        
      Aim();
      
      Movement();
      
    }

    void Aim(){
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        
        transform.Rotate(Vector3.up,mouseX * _mouseSensitivity);

        _currentTilt -= mouseY * _mouseSensitivity;
        _currentTilt = Mathf.Clamp(_currentTilt,-90,90);
        _cam.transform.localEulerAngles = new Vector3(_currentTilt,0,0);
    }

    void Movement(){
       bool waswalking = iswalking;
        Vector3 sizewaysMovementVector =  transform.right * Input.GetAxis("Horizontal");
        Vector3 forwardBackwardMovementVector = transform.forward * Input.GetAxis("Vertical");
        Vector3 movementVector = sizewaysMovementVector + forwardBackwardMovementVector;

        if(movementVector.magnitude > .5){
            iswalking = true;
        }
        else{
            
            iswalking = false;
            walk.stopSound();
        }


        if(waswalking != iswalking){
            if(iswalking){
                walk.PlaySound();
            }
            else{
                walk.stopSound();
            }
        }
        GetComponent<CharacterController>().Move(movementVector * _movespeed * Time.deltaTime);
    }

    void walking(){

    }

}
