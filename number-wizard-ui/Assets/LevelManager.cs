﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Level load Request for : " + name);
		Application.LoadLevel (name);
	}

	public void QuitGame(){
		Debug.Log ("I want to quit");
		Application.Quit ();
	}
}
