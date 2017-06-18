using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public GameObject player;

	private GameObject instantiatebullet;
    private float cooldown = 1f, cdTimer = 0;



    private void Update()
    {
        if (cdTimer >= cooldown)
        {
            Shoot();
            print("r");
        }
        else
        {
            cdTimer += 0.02f;
        }
    }


    void Shoot()
	{
		if (Input.GetKey("up")){
			
            Launch(4);
		}
		else if (Input.GetKey("down")){
			
            Launch(2);
        }
		else if (Input.GetKey("left")){
			
            Launch(3);
        }
		else if (Input.GetKey("right")){
			
            Launch(1);
        }
	}

    void Launch(int dir)
    {
        instantiatebullet = Instantiate(bullet);
        instantiatebullet.GetComponent<ArrowMovement>().direction = dir;
        instantiatebullet.transform.position = player.transform.position;
        instantiatebullet.transform.Rotate(0, 0, -90*instantiatebullet.GetComponent<ArrowMovement>().direction);
        cdTimer = 0;
    }
}
