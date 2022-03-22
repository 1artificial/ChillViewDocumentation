

using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitscene : MonoBehaviour
{
    public void Quit ()
    {
        Application.Quit();
    }

    public void CreditJebana()
    {
        SceneManager.LoadScene("credits1");
    }
}
