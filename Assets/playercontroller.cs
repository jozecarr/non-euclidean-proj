using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Transform camTrans;
    public float moveSpeed = 5f;
    private Rigidbody playerRB;

    private 

    void Start(){
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(0, camTrans.rotation.eulerAngles.y, 0);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 cameraForward = camTrans.forward;
        Vector3 cameraRight = camTrans.right;
        cameraForward.y = 0f;
        cameraRight.y = 0f;
        cameraForward.Normalize();
        cameraRight.Normalize();

        Vector3 movement = (cameraForward * verticalInput + cameraRight * horizontalInput).normalized;
        playerRB.velocity = movement * moveSpeed;
    }
}
