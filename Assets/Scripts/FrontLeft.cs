using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontLeft : MonoBehaviour
{
    public Rigidbody rb;
    //public Transform car;
    public float speed = 17;
    Vector3 rotationLeft = new Vector3(0, -30, 0);


    void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}
