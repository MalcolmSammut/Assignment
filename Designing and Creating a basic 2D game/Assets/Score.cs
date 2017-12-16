using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	private static int score;
	private static int score2;
	public Text finalscore;

	void Update(){
		score = Scoreboard.total1;
		score2 = Scoreboard.total2;
		if (score < score2) {
			finalscore.text = "Player 2 Won score: " + score2.ToString ();
		}
		if (score2 < score) {
			finalscore.text = "Player 1 Won score: " + score.ToString ();
		}
	}
}