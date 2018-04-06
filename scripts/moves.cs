using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class moves : MonoBehaviour {
	public class Global {
		public static int move=0 ;
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
		else if (scene.name.Equals ("Stage3")) {
			moves.Global.move = 15;
		}
		else if (scene.name.Equals ("Stage4")) {
			moves.Global.move = 12;
		}
		else if (scene.name.Equals ("Stage5")) {
			moves.Global.move = 6;
		}
		else if (scene.name.Equals ("Stage6")) {
			moves.Global.move = 21;
		}
		else if (scene.name.Equals ("Stage7")) {
			moves.Global.move = 10;
		}
		else if (scene.name.Equals ("Stage8")) {
			moves.Global.move = 16;
		}
		else if (scene.name.Equals ("Stage9")) {
			moves.Global.move = 20;
		}
		else if (scene.name.Equals ("Stage10")) {
			moves.Global.move = 27;
		}
	}

	void Update(){

	}
}
