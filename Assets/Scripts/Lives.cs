using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {

	public GameObject life;

	private GameObject instantiatelife;
	private Vector2 setposition;

	public float number;

	private float number2;

	// Use this for initialization
	void Start () {
		number2 = 0;
		do {
			number2=number2+1;
			instantiatelife = Instantiate (life);
			setposition = new Vector2 (transform.position.x + number2, transform.position.y);
			instantiatelife.transform.parent = transform;
			instantiatelife.transform.position = setposition;
			instantiatelife.name = "Life("+number2+")";
		} while(number2 <number );
	}

}
