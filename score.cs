using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Transform player;
	public Text scoretext;
	public Vector3 offset;


	void Update () {
		Debug.Log ("player.position.z");
		player.position = player.position + offset;
		scoretext.text = player.position.z.ToString("0");
	}
}
