

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }
    
    public void QuitTheCurrentGame()
    {
        Application.Quit();
    } 
    
     public void HowToPlayButtonPressed()
    {
        SceneManager.LoadScene("how to play");
    }

    public void CreditsMyMan()
    {
        SceneManager.LoadScene("credits1");
    }
}   