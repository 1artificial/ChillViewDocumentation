

using UnityEngine;
using UnityEngine.SceneManagement;

public class gggameManager : MonoBehaviour { 

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGameBro()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("get beeter");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
    
}
