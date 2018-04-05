using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class moves : MonoBehaviour {
	public class Global {
		public static int move = 5;
	}
	Scene scene;
	void Start(){
		scene = SceneManager.GetActiveScene ();
		if (scene.name.Equals ("Stage1")) {
			moves.Global.move = 5;
		}
		else if (scene.name.Equals ("Stage2")) {
			moves.Global.move = 6;
		}
	}
	void Update(){

	}
}
