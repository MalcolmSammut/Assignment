using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		int rand = Random.Range (0, 2);
		if (rand == 0) {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-8f, 0f);
		}
		else if(rand==1){
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (8f, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onCollisionEnter2D(Collider2D hit){
		float distance = this.transform.position.y - GameObject.Find ("Player1").transform.position.y;
		float distance2 = this.transform.position.y - GameObject.Find ("Player2").transform.position.y;
		if (hit.gameObject.name=="Player1") {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (8f,distance*2f);
		}
		if(hit.gameObject.name=="Player2"){
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-8f,distance2*2f);
		}
	}
}
