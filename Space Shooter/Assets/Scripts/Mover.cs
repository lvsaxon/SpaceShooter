using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed, damage;
	public GameObject hazard;
	GameController gc;
	//bool acc;

	void Start(){
		GetComponent<Rigidbody>().velocity = transform.forward*speed;

		if(hazard){
		   speed = Random.Range (-7, -3);
		   GetComponent<Rigidbody>().velocity = transform.forward*speed;
		}  
	}

	void Update(){

	}
	
	/*void FixedUpdate(){

		if(forceObject.gameObject.tag == "Hazard")
			forceObject.rigidbody.AddForce(Vector3.forward * speed);
    }

    /*void OnTriggerEnter(Collider collider){

		if(collider.tag == "Player")
			if(speed<0f)
			   acc=true;
	}*/
}
