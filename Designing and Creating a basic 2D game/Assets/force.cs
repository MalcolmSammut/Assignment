using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horzontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0F, moveVertical);
		rb.AddForce (movement);
	}
}
