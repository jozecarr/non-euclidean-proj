using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform playerTrans;
    public float sens;
    private Vector3 deltaMouse;

    void Start(){
        deltaMouse = Input.mousePosition;
    }
    void Update(){
        transform.position = playerTrans.position;

        deltaMouse = Input.mousePosition - deltaMouse;
        
        // Modify the camera's rotation based on deltaMouse
        float rotateX = -deltaMouse.y * sens;
        float rotateY = deltaMouse.x * sens;

        // Limit the rotation around the X axis to prevent Z rotation changes
        float currentXRotation = transform.localEulerAngles.x;
        float newRotationX = currentXRotation + rotateX;
        newRotationX = Mathf.Clamp(newRotationX, -90f, 90f); // Limit the X rotation to -90 to 90 degrees

        transform.localEulerAngles = new Vector3(newRotationX, transform.localEulerAngles.y + rotateY, 0);

        deltaMouse = Input.mousePosition;
    }
}
