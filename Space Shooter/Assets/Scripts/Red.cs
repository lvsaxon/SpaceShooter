using UnityEngine;
using System.Collections;

public class Red : MonoBehaviour {

	public GameObject redHazard;
	
	void Start(){
		redHazard.GetComponent<Renderer>().material.color = Color.red;
	}
}
