using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

   // Public WheelCollider mycolider; 
   public WheelCollider MyCollider;
    private float speed=0;

    void Update()
    {
        transform.rotation = MyCollider.transform.rotation * Quaternion.Euler(speed, MyCollider.steerAngle, 0);
        speed += MyCollider.rpm * 360 / 60 * Time.deltaTime;
    }
}
