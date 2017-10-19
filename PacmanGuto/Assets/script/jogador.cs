using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jogador : MonoBehaviour {
	private float speed = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}
	void move(){
		float Horizontal = Input.GetAxis ("Horizontal");
		float Vertical = Input.GetAxis ("Vertical");

		Rigidbody2D rigi2d = GetComponent<Rigidbody2D> ();
	
		if (Horizontal > 0) {
			rigi2d.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
		}
		if (Horizontal < 0) {
			rigi2d.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
		}
		if (Vertical < 0) {
			rigi2d.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
		}
		if (Vertical > 0) {
			rigi2d.velocity = new Vector2 (Horizontal * speed, Vertical * speed);
		}
	}
}
