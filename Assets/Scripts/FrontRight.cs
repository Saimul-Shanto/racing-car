using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRight : MonoBehaviour
{
    public Rigidbody rb;
    //public Transform car;
    public float speed = 17;


    Vector3 rotationRight = new Vector3(0, 30, 0);

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }
    }
}
