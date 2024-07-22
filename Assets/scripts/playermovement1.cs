

using UnityEngine;

public class playermovement1 : MonoBehaviour
{

    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    //Physics
    void FixedUpdate ()
    {
        //foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    
    }

}












 
 