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
        transform.Rotate(0, deltaMouse.x, 0);
        deltaMouse = Input.mousePosition;
    }
}
