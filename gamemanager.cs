using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour {
	public float restartdelay=8;
	bool gamehasended=false;
	public void endgame()
	{
		if (gamehasended == false) {
			Debug.Log ("GAME OVER ");
			gamehasended = true;
			restart ();
			Invoke ("restart", restartdelay);
		}
	}
	void restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	
	}
	public void quuit(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	
	}
}
