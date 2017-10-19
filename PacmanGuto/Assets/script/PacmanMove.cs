using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour {
	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;
	// Use this for initialization
	void Start () {
		dest = transform.position;
		Debug.Log ("Acima" + Vector2.up);
		Debug.Log ("Baixo" + Vector2.down);
		Debug.Log ("Direita" + Vector2.right);
		Debug.Log ("Esquerda" + Vector2.left);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 p = Vector2.MoveTowards (transform.position, dest, speed);
		GetComponent<Rigidbody2D> ().MovePosition (p);

		//if ((Vector2)transform.position == dest) {

			if (Input.GetKey (KeyCode.UpArrow) && valid (Vector2.up))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey (KeyCode.RightArrow) && valid (Vector2.right))
				dest = (Vector2)transform.position + Vector2.right;
			if (Input.GetKey (KeyCode.DownArrow) && valid (-Vector2.up))
				dest = (Vector2)transform.position - Vector2.up;
			if (Input.GetKey (KeyCode.LeftArrow) && valid (-Vector2.right))
				dest = (Vector2)transform.position - Vector2.right;
		//}
		Vector2 dir = dest - (Vector2)transform.position;
		Debug.Log ("Direção" + dir);

		GetComponent<Animator> ().SetFloat ("Dirx", dir.x);
		GetComponent<Animator> ().SetFloat ("Diry", dir.y);

	}
	bool valid(Vector2 dir){
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
		return (hit.collider == GetComponent<Collider2D> ());
	}
}
