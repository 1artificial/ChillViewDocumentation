
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gggameManager GAMEmanager;

   void OnTriggerEnter()
    {
        GAMEmanager.CompleteLevel();
    }
}
