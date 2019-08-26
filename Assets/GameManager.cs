using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
       
    public bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameManager gameManager;


    public void CompleteLevel()

    {
        Debug.Log("COMPLETE LEVEL");
    }





    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //Restart
        }
  
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
