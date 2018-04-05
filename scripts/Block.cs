using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public enum Direction {
	North,
	South,
	East,
	West
}
public class Block : MonoBehaviour {
	// Use this for initialization
	Scene scene;
	public AudioSource gameover;
	public AudioSource box_sound;
	private Rigidbody rb;
	public float rotationSpeed = 500;
	[SerializeField]private Text moveText;
	private bool _moving;
	private Direction _rotationDirection;
	private Vector3 _pivot;
	private float _totalRotation;
	private Vector3 _axis;
	private Vector3 _scale;
	private int move_count;
	void Start () {
		move_count = 0;
		scene = SceneManager.GetActiveScene();
			_moving = false;
		_scale = transform.localScale/2.0f;
		moveText.text = "Moves: " + moves.Global.move;
	}
	
	// Update is called once per frame
	void Update () {
		if (_moving) {
			float deltaRotation = rotationSpeed * Time.deltaTime;
			if (_totalRotation + deltaRotation >= 90) {
				deltaRotation = 90 - _totalRotation;
				_moving = false;
			}
			if ((_rotationDirection == Direction.West) || (_rotationDirection == Direction.North))
				transform.RotateAround (_pivot, _axis, deltaRotation);
			else
				transform.RotateAround (_pivot, _axis, -deltaRotation);

			_totalRotation += deltaRotation;
		} else if (Input.GetKeyUp (KeyCode.W)) {
			box_sound.Play ();
			moves.Global.move--;
			move_count++;
			moveText.text = "Moves: " + moves.Global.move;
			Rotate (Direction.North);
		} else if (Input.GetKeyUp (KeyCode.A)) { 
			box_sound.Play ();
			moves.Global.move--;
			move_count++;
			moveText.text = "Moves: " + moves.Global.move;
			Rotate (Direction.West);
		} else if (Input.GetKeyUp (KeyCode.S)) {
			box_sound.Play ();
			moves.Global.move--;
			move_count++;
			moveText.text = "Moves: " + moves.Global.move;
			Rotate (Direction.South);
		} else if (Input.GetKeyUp (KeyCode.D)) {
			box_sound.Play ();
			moves.Global.move--;
			move_count++;
			moveText.text = "Moves: " + moves.Global.move;
			Rotate (Direction.East);
		} else if (moves.Global.move < 0) {
			gameover.Play ();
			Invoke ("Reset", 2.5f);
			moves.Global.move = move_count;
			//Application.LoadLevel(scene.buildIndex);
		}
		else if(Input.GetKeyUp(KeyCode.Escape)){
			Application.LoadLevel("SplashScreen");
		}

	}

	void Rotate(Direction direction){
		_rotationDirection = direction;
		_moving = true;
		_totalRotation = 0;

		switch(_rotationDirection){
		case Direction.East:
			_pivot = transform.position + new Vector3(_scale.x,-_scale.y,0);
			break;
		case Direction.West:
			_pivot = transform.position + new Vector3(-_scale.x,-_scale.y,0);
			break;
		case Direction.North:
			_pivot = transform.position + new Vector3(0,-_scale.y,_scale.z);
			break;
		case Direction.South:
			_pivot = transform.position + new Vector3(0,-_scale.y,-_scale.z);
			break;
		}

		if((_rotationDirection== Direction.East)||(_rotationDirection == Direction.West)){
			_axis = Vector3.forward;
			float temp = _scale.x;
			_scale.x = _scale.y;
			_scale.y = temp;
		}else{
			_axis = Vector3.right;
			float temp = _scale.z;
			_scale.z = _scale.y;
			_scale.y = temp;
		}
	}

	void OnCollisionEnter(Collision collide)
	{    
		if(collide.gameObject.name == "collide_reset")        
		{
			Invoke ("Reset", 2f);
		}
		else if(collide.gameObject.name == "next_stage")        
		{
			Invoke ("NextLevel", 2f);
		}
	}
	void Reset(){
		Application.LoadLevel (scene.buildIndex);
	}
	void NextLevel(){
		Application.LoadLevel (scene.buildIndex + 1);
	}

}