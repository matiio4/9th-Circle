using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject myCamera;
	public GameObject lives;

	private GameObject lifetodestroy;

	private Rigidbody2D rb2d;

	public float speed;

	public float numberoflife;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement*speed);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("DoorW")) {
			transform.Translate (0, 6, 0);
			myCamera.transform.Translate (0, 20, 0);
			lives.transform.Translate (0, 20, 0);
			other.transform.parent.GetComponent<EnemyGroupBehaviour> ().ressurected = 1;
		} else if (other.gameObject.CompareTag ("DoorS")) {
			transform.Translate (0, -6, 0);
			myCamera.transform.Translate (0, -20, 0);
			lives.transform.Translate (0, -20, 0);
			other.transform.parent.GetComponent<EnemyGroupBehaviour> ().ressurected = 1;
		} else if (other.gameObject.CompareTag ("DoorA")) {
			transform.Translate (-6, 0, 0);
			myCamera.transform.Translate (-35.5f, 0, 0);
			lives.transform.Translate (-35.5f, 0, 0);
			other.transform.parent.GetComponent<EnemyGroupBehaviour> ().ressurected = 1;
		} else if (other.gameObject.CompareTag ("DoorD")) {
			transform.Translate (6, 0, 0);
			myCamera.transform.Translate (35.5f, 0, 0);
			lives.transform.Translate (35.5f, 0, 0);
			other.transform.parent.GetComponent<EnemyGroupBehaviour> ().ressurected = 1;
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag ("Enemy")) {
			numberoflife = lives.GetComponent< Lives > ().number;
			lives.GetComponent< Lives > ().number = numberoflife - 1;
			lifetodestroy = GameObject.Find ("Life(" + numberoflife + ")");
			Destroy (lifetodestroy);
		}
	}		
		
}
