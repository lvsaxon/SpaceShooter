using UnityEngine;
using System.Collections;

public class SaveChild : MonoBehaviour {

	GameObject star;
	GameObject[] asteroid;
	Mover[] mover;

	void Start(){
		star = GameObject.FindGameObjectWithTag("Star");
		asteroid = GameObject.FindGameObjectsWithTag("Star_Asteroid");

	}

	void Update() {

		if(star.transform.parent == null)
		   transform.DetachChildren();
	}
}
