using UnityEngine;
using System.Collections;

public class Yellow : MonoBehaviour {

	public GameObject yellowHazard;
	
	void Start(){
		yellowHazard.GetComponent<Renderer>().material.color = Color.yellow;
	}
}
