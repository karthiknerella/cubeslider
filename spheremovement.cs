using UnityEngine;

public class spheremovement : MonoBehaviour {

	// Calculate other rectangles


	// Use this for initialization
	public Rigidbody rb;
	public float forwardforce=2000;
	public float sidewaysforce=500;
	// Update is called once per frame
	void FixedUpdate () {
				rb.AddForce(0,0,forwardforce*Time.deltaTime);
		//bool h = Input.GetAxis ("Horizontal");

		if(Input.GetKey("d"))
		{
			rb.AddForce (sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}
		if(Input.GetKey("a"))
		{
			rb.AddForce (-sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}
		/*if(Input.GetKey("keyCode.LeftArrow"))
		{
			rb.AddForce (-sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}
		if(Input.GetKey("keyCode.RightArrow"))
		{
			rb.AddForce (sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}*/
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch (0);
			if (touch.position.x < Screen.width/2)
			{
				rb.AddForce (-sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

			}
			 if (touch.position.x > Screen.width/2)
			{
				rb.AddForce (sidewaysforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

				//Move Player Right
			}
		}
		if (Input.acceleration.x > 0) {
			transform.Translate (Input.acceleration.x, 0, Input.acceleration.z);
		}

		if (rb.position.y < -.5) {
			FindObjectOfType<gamemanager> ().endgame ();
		}
	}
}
