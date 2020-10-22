using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
    

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }

    }
}
