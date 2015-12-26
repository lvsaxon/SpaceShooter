using UnityEngine;
using System.Collections;

public class BackgroudScroller : MonoBehaviour {

	public float scrollSpeed;
	public float tileSizeZ;
	Vector3 startPos;

	void Start(){
		startPos = transform.position;
	}

	void Update(){
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPos + Vector3.forward * newPosition;
    }
}
