using UnityEngine;

public class followscript : MonoBehaviour {

	public Transform player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		
			transform.position = player.position+offset;
		/*if (!float.IsNaN (transform.position.x) && !float.IsNaN (transform.position.y) && !float.IsNaN (transform.position.z)) {
			FindObjectOfType<gamemanager> ().endgame ();

		}*/
	}
}
