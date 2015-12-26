using UnityEngine;
using System.Collections;

public class TrackPlayerPosition : MonoBehaviour {

	Transform player;
	DestroyOnContact target;
	NavMeshAgent nav;
	TrackPlayerPosition trackPlayer;
	
	void Start (){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		trackPlayer = GetComponent<TrackPlayerPosition>();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update (){

		if(player.transform != null){
		   Transform[] star = GetComponents<Transform>();
		      foreach(Transform starHazard in star)
		         if(starHazard.position.z >= player.transform.position.z)
		            nav.SetDestination(player.position);
			     if(player.transform == null){
				    nav.enabled = false;
				    trackPlayer.enabled = false;
			     }
		}
	}
}
