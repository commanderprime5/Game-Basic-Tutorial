using UnityEngine;

public class PlayerColission : MonoBehaviour{

    public playerMovement movement;
    

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstakel")
        {
            movement.enabled = false;
            FindObjectOfType <GameManager>().EndGame();
        }

    }

}

  


	