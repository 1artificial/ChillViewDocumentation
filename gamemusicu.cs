
using UnityEngine;

public class gamemusicu : MonoBehaviour
{
    static gamemusicu instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    
    
}
