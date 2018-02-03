using UnityEngine.SceneManagement;
using UnityEngine;

public class WELCOME : MonoBehaviour {
	public void startgame(){
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
}
