using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {
	private int count;
	private int count2;
	public Text Score;
	public Text Score2;
	void Start(){
		count = 0;
		setCountText ();
		count2 = 0;
		setCountText ();
	}
	void OnCollisionEnter2D(Collision2D Col){
		if(Col.gameObject.name == "Goal"){
			Debug.Log("Player 1 Scores");
			count = count + 1;
			setCountText ();
		}else if(Col.gameObject.name == "Goal2"){
			Debug.Log("Player 2 Scores");
			count2 = count2 + 1;
			setCountText ();
		}
	}

	void setCountText(){
		Score.text = "Score: " + count.ToString ();
		Score2.text = "Score: " + count2.ToString ();
	}
}
