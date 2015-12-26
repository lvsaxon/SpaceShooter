using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	
	public float tumble, degrees;
	public GameObject star;
	GameObject[] asteroid;


	void Start(){

		asteroid = GameObject.FindObjectsOfType(typeof(GameObject))as GameObject[];
		//asteroid = GameObject.FindGameObjectsWithTag("Star_Asteroid");


		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere*tumble;

	}

	void Update(){

		//foreach(GameObject hazard in asteroid)
		if(star!=null)
	       transform.RotateAround(star.transform.position, Vector3.up, degrees * Time.deltaTime);
		else
		   OnDestroy();
	}

	void OnDestroy(){

		//foreach(GameObject hazard in asteroid)
			for(int i=0; i<1; i++)
			    if(asteroid[i] != null)
			       GetComponent<Rigidbody>().velocity = asteroid[i].transform.forward * -10;
	}
}
