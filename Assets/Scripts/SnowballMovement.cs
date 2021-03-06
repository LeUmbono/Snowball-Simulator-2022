using UnityEngine;

public class SnowballMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float movementForce = 2000f;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movementForce * Time.deltaTime);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movementForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0);
        }

    }
}