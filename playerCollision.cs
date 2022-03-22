
using UnityEngine;

public class playerCollision : MonoBehaviour
{
	public playermovement movement;    
	
	void OnCollisionEnter(Collision collisionInfo)
	{
		
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<gggameManager>().EndGameBro();
		}
	}
}
