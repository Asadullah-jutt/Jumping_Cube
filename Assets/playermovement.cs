using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //public Transform playermove;
    public Rigidbody rb;

    public int sideways_force;
    void Start()
    {
        rb.AddForce(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, sideways_force * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
