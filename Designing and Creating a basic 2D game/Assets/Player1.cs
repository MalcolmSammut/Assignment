using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//this should print in the console the position of the cursor
		float mousePosInBlocks = (Input.mousePosition.y / Screen.width * 8) - 4f;
		Vector3 paddlePosition = new Vector3(this.transform.position.x, mousePosInBlocks , 0f);
		if (paddlePosition.y > 2.2f)
			paddlePosition.y = 2.2f;
		else if (paddlePosition.y < -3.3f)
				paddlePosition.y = -3.3f;

		this.transform.position = paddlePosition;

		//-4f stands for half the screen width in units. This is done so that the mouse and paddle move underneath each other

	}
}
