using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {
	bool input;
	// Use this for initialization
	void Start () {
		input = true;	
	}

	void LoadGameScene(){

		SceneManager.LoadScene("SplashScreen");
	}
	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Update () {

		if (Input.GetKeyUp(KeyCode.Space)) {
			Destroy (gameObject);
			Invoke ("Stage1", 1f);
			input = false;
		}
		else if (Input.GetKeyUp(KeyCode.Q)) {
			Destroy (gameObject);
			input = false;
		}
	}
}
