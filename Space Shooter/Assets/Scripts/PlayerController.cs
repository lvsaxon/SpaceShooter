using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary{
    
	public float xMin, xMax, zMin, zMax;
}

[System.Serializable]
public class Shooting{

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
}

public class PlayerController : MonoBehaviour {

	public float speed;
	public float xTilt, zTilt;
	public Boundary boundary;

	private float nextFire;
	public Shooting shooting;

	void Update(){


		if(Input.GetKey(KeyCode.Space) && Time.time > nextFire) {
			nextFire = Time.time+shooting.fireRate;
			Instantiate(shooting.shot, shooting.shotSpawn.position, shooting.shotSpawn.rotation);
		}
	}

	void FixedUpdate() {

		float moveHor = Input.GetAxis ("Horizontal");
        float moveVer = Input.GetAxis ("Vertical");
	
		Vector3 move = new Vector3 (moveHor, 0.0f, moveVer);
		GetComponent<Rigidbody>().velocity = move*speed;

		GetComponent<Rigidbody>().position = new Vector3 (Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
		                                  0.0f, 
		                                  Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax));
		//Tilts the Vehicle's direction
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -xTilt);

	}
}
