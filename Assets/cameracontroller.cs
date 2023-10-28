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
        transform.Rotate(Vector3.up, deltaMouse.x, Space.World);
        transform.Rotate(Vector3.right, -deltaMouse.y);

        deltaMouse = Input.mousePosition; 
    }
}
