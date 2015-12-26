using UnityEngine;
using System.Collections;

public class Recursion : MonoBehaviour {
 
	public GameObject asteroid;
	public float distance;
	float centerX, centerZ;
	GameObject star;

	void Start(){
		star = GameObject.FindGameObjectWithTag("Star");
		/*centerX = star.transform.position.x + distance;
		centerZ = star.transform.position.z + distance;*/

		GameObject starAsteroid = Resources.Load("Star_Asteroid")as GameObject;

			//asteroid.transform.position = new Vector3(centerX , 0, 0);
			//centerX*=-i;
		}
	}

	/*void Update(){
		
		cicle formula: ((x+1)^2)/4 + ((y+1)^2)/4 for rotating asteroids around sphere
		asteroid.transform.Translate(1, 0.0f, 0);
    }*/

	