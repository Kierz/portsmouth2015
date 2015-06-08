//Last edited by James Davidson
//08.06.2015
//playerController.cs

using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
	private GameObject player;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//Assign and update the movement values. Yo.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Store the movement in a vector3. X, Y & Z. We don't move up on the Y axis so set to 0.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		transform.Rotate (Vector3.up * Time.deltaTime);
	
		//Add the force to the rigid body, depending on the speed.
		rb.AddForce (movement * speed);
	}
}
