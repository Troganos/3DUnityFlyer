using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;

    public float ForwardF = 1000F;
    public float DownF = 10F;
    public float DirectionalF = 1000F;
  

    void FixedUpdate()
    {

        rb.AddForce(0, 0, ForwardF * Time.deltaTime);

        rb.AddForce(0, -DownF * Time.deltaTime, 0);

        if (Input.GetKey("a"))
        {

            rb.AddForce(-DirectionalF, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            
            rb.AddForce(DirectionalF, 0, 0);

        }
    }
}