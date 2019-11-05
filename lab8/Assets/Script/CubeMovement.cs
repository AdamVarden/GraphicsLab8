using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;
    // Start is called before the first frame update
    void Start()
    {
         moveSpeed = 3f;
         rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;

//  if (Input.GetKey(KeyCode.W))
//         {
//             transform.Translate(Vector3.forward * Time.deltaTime);
//         }

//         if (Input.GetKey(KeyCode.S))
//         {
//             transform.Translate(Vector3.back * Time.deltaTime);
//         }

//          if (Input.GetKey(KeyCode.A))
//         {
//              transform.Translate(Vector3.left * Time.deltaTime);
//         }

//         if (Input.GetKey(KeyCode.D))
//         {
//             transform.Translate(Vector3.right * Time.deltaTime);
//          }       
         }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX,rb.velocity.y,dirZ);
    }
}