using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScreen : MonoBehaviour {
	bool input;
	void Start () {
		input = true;	
	}


	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Update () {

		if (Input.GetKeyUp(KeyCode.E)) {
			Destroy (gameObject);
			SceneManager.LoadScene("SplashScreen");
			input = false;
		}

	}
}
