//Last edited by James Davidson
//08.06.2015
//playerController.cs


using UnityEngine;
using System.Collections;

public class playerControlle : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb; 
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//Assign and update the movement values. Yo.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
}
