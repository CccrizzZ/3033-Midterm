using UnityEngine;
using UnityEngine.InputSystem;



public class FPS_Camera_newinput : MonoBehaviour
{


    public float MouseSensitivity = 100.0f;
    public Transform PlayerBody;
    


    float XRotation = 0.0f;

    public bool canLook;



    void Start()
    {
        ResetCameraRot();
        SetCameraMove();
    }


    public void ResetCameraRot()
    {
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        XRotation = 0.0f;
    }


    public void SetCameraMove()
    {
        // lock cursor to the center of screen
        canLook = true;
        Cursor.lockState = CursorLockMode.Locked;
    
    }

    public void SetCameraFreeze()
    {
        // dont lock cursor
        canLook = false;
        Cursor.lockState = CursorLockMode.None;

    }


    void Update()
    {
    }

    




    void OnLook(InputValue input)
    {
        
        if (canLook)
        {

            // // set mouse input
            float MouseX = input.Get<Vector2>().x * MouseSensitivity / 500;
            // float MouseY = input.Get<Vector2>().y * MouseSensitivity / 500;
            
            XRotation += MouseX;

            // // // clamp rotation to +90 and -90 deg
            // XRotation -= MouseY;
            // XRotation = Mathf.Clamp(XRotation, -90.0f, 90.0f);


            
            // // rotate player body
            transform.localRotation = Quaternion.Euler(0.0f, XRotation, 0.0f);

            // PlayerBody.Rotate(Vector3.up * MouseX);

            



        
            
        }
    }




}
