using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public Movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Walls")
        {

            rb.GetComponent<Rigidbody>().useGravity = true;
            movement.enabled = false;
           
        }

    }
}