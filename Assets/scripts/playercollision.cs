
using UnityEngine;

public class playercollision : MonoBehaviour{

    public playermovement1 movement;
   

    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.name == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
            


    }
       

}
   
