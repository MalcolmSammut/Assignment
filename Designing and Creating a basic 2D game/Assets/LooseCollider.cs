using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {
	public levelmanager levelManager;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision) //this is triggered when a collision happens
	{
		print("Collision");    
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		print("Trigger");
		levelManager.LoadLevel("Win");  //loads WIn Scene when ball enteres Trigger
	}


}
