using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour {
	public AudioSource gameover;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {	

	}
	void OnCollisionEnter(Collision collide)
	{    
		if(collide.gameObject.name == "Block")        
		{
			gameover.Play ();
		}
	}

}
