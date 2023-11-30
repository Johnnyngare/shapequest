
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewayForce = 2000f;
    public float forwardForce = 500f;

    // We marked this as "Fixed Update" because we 
    // are using it to manipulate the physics
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Add a sideway force only if 'd' key is pressed
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Add a sideway force only if 'a' key is pressed
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
