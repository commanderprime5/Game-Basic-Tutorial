using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;

    public void EndGame()
    {
        if(GameHasEnded==false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");

        }
        
    }

    
}
