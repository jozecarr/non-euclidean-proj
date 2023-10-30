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

        int w = Input.GetKey(KeyCode.W) ? 1 : 0;
        int a = Input.GetKey(KeyCode.A) ? -1 : 0;
        int s = Input.GetKey(KeyCode.S) ? -1 : 0;
        int d = Input.GetKey(KeyCode.D) ? 1 : 0;

        int forwardsAmount = w + s;
        int rightAmount = d + a;

        Vector2 movement = new Vector2(rightAmount, forwardsAmount).normalized;

        Vector3 movement2 = (transform.forward * movement.y + transform.right * movement.x).normalized;
        playerRB.velocity = movement2 * moveSpeed;
    }
}
