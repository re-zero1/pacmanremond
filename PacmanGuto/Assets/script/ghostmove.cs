using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostmove : MonoBehaviour {
	public Transform [] Wayponits;
	int cur = 0;
	public float speed = 0.3f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position != Wayponits [cur].position) {
			Vector2 p = Vector2.MoveTowards (transform.position, Wayponits [cur].position, speed);
			GetComponent<Rigidbody2D> ().MovePosition (p);
		} else {
			cur = (cur + 1) % Wayponits.Length;
		}
		Vector2 dir = Wayponits[cur].position - transform.position;
		GetComponent<Animator> ().SetFloat ("Dirx", dir.x);
		GetComponent<Animator> ().SetFloat ("Diry", dir.y);


		}
	void OnTriggerEnter2D(Collider2D co){
		if (co.name == "pacman")
			Destroy (co.gameObject);
	}
}
