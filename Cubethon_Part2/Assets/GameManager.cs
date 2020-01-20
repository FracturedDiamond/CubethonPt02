using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;                  // Initialize gameHasEnded to 'false'
    public float restartDelay = 1f;             // Initialize restartDelay to '1f'
    public GameObject completeLevelUI;          // Declare completeLevelUI gameObject


    public void CompleteLevel ()                // Function for completing a level
    {
        completeLevelUI.SetActive(true);        // Allow completeLevelUI to be seen
    }




    public void EndGame ()                      // Function to end the game -- public so other scripts can see
    {
        if (gameHasEnded == false)              // Check to see if game has ended yet
        {
            gameHasEnded = true;                // set gameHasEnded to 'true'

            Invoke("Restart", restartDelay);    // Restart the game
        }
    }

    void Restart ()                             // Function to restart the game
    {
        // Reload the active scene (i.e. if you are on level 02 it will restart level 02)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
