using UnityEngine;
using System.Collections;

public class ExplosionsVanish : MonoBehaviour {

	public float lifeTime;

	void Start(){
        Destroy(gameObject, lifeTime);
	}
}
