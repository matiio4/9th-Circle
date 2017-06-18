using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

	public float speed;
	public float direction;

	public GameObject player;

	void Start() {
		Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	// Update is called once per frame
	void Update () {
        if (direction == 1)
        {
            transform.Translate(0, speed, 0);
        }
            
		if (direction == 2) {
			transform.Translate (0, speed, 0);
		}
		if (direction == 3) {
			transform.Translate (0, speed, 0);
		}
		if (direction == 4) {
			transform.Translate (0, speed, 0);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag("Wall")) {
			Destroy (gameObject);
		}		
	}
}
