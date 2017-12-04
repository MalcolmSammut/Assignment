using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(string name)
	{
		print("Level Load requested for " + name);
		SceneManager.LoadScene(name);
	}
	public void quitGame(){
		Application.Quit ();
	}
}