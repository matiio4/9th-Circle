using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroupBehaviour : MonoBehaviour {

	GameObject[] other;

	public float ressurected;
	public float deaths;

	private float numberofmonsters;

	// Use this for initialization
	void Start () {

		deaths = 0;
		foreach (Transform child in transform) 
			if (child.CompareTag ("Enemy")) {
				child.GetComponent<EnemyBehaviour> ().state = 1;
				deaths++;
			}
		ressurected = 0;
		numberofmonsters = deaths;
	}

	void Update()
	{
		if (deaths > 0) {
			if (ressurected == 1) {
				foreach (Transform child in transform)
					if (child.CompareTag ("Enemy")) {
						child.gameObject.SetActive (true);
						child.GetComponent<EnemyBehaviour> ().state = 1;
						deaths = numberofmonsters;
					}
				ressurected = 0;
			}
		}
	}
}
