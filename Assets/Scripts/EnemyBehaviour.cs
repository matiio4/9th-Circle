using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

	public GameObject player;

	public float speed;
	public float state;

	private Vector2 setposition; 

	// Use this for initialization
	void Start () {
		setposition = new Vector2 (transform.position.x, transform.position.y);
	}
		
	void OnWillRenderObject(){
		transform.position = Vector2.MoveTowards (transform.position, player.transform.position, speed);
	}

	void OnBecameInvisible() {
		transform.position = setposition;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag("Arrow")) {
			Destroy (other.gameObject);
			transform.parent.gameObject.GetComponent<EnemyGroupBehaviour> ().deaths--;
			state = 0;
			gameObject.SetActive (false);
		}		
	}
}
