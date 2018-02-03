using UnityEngine.SceneManagement;
using UnityEngine;

public class playercollision : MonoBehaviour {
	public spheremovement movement;
	public gamemanager gamemanager;
	public WELCOME welcome;
	public credits credit;

	void OnCollisionEnter(Collision collisioninfo)
	{   
		if (collisioninfo.collider.name == "cylinder") {
			movement.enabled = false;
			//FindObjectOfType<welcome> ().startgame();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
			//Application.Quit ();
		}

		 if (collisioninfo.collider.name == "obstacle") {
		movement.enabled = false;
		FindObjectOfType<gamemanager> ().endgame ();
		

		}
	 
	}
}
