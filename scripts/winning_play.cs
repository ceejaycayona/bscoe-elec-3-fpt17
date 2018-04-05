using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning_play : MonoBehaviour {
	public AudioSource win;
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
			win.Play ();
		}
	}
}
