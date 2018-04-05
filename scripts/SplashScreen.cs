using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
			Application.LoadLevel ("Stage1");
		} else if (Input.GetKeyUp (KeyCode.Q)) { 
			Application.LoadLevel ("HowToPlay");
		}
	}
}
