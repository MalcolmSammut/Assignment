using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {
	public GameObject Player;

	void Start ()
	{
	}
	const float speed = 10;
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			Player.transform.Translate (Vector3.up* Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Player.transform.Translate (Vector3.down * Time.deltaTime * speed);
		}
	}
}
