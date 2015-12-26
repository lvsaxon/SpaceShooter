using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	public GameObject explosion, playerExplosion;
	public int scoreValue;
    private GameController gameController;

	public void Start(){

		GameObject gameControllerObj = GameObject.FindWithTag("GameController");
		if(gameControllerObj != null) 
		   gameController = gameControllerObj.GetComponent <GameController> ();
		else
		   Debug.Log ("Cannot Find 'GameController' Script");

	}

	//OnTriggerEnter used for when gameObj makes contact when trigger is on
	void OnTriggerEnter(Collider collid){

		if(collid.tag == "Boundary")
		   return;

		Instantiate (explosion, transform.position, transform.rotation);
        
		if(collid.tag == "Player") {
			scoreValue=50;
			Instantiate (playerExplosion, collid.transform.position, collid.transform.rotation);
			gameController.GameOver();
		}

		gameController.AddScore(scoreValue);
        Destroy(collid.gameObject);
		Destroy(gameObject);
	}


}
