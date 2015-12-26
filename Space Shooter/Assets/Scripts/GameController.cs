using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard, yellowHazard, redHazard; 
	public GameObject Star;
	public Vector3 spawnValues;

	public int hazardLoop; 
	public float spawnTime, startTime, waveTime, timer;
	public GUIText scoreText, restartText, gameOverText;

	private bool gameOver, restart;
	private int score, count; 
	
	void Start(){

		gameOver = false;
		restart = false;
		restartText.text = "";
        gameOverText.text = "";
		 
		score=0;
		UpdateScore();
		StartCoroutine(SpawnWaves());

	}

	//Initailizes input for player
	void Update(){
		timer+=Time.deltaTime;
		count = (int)timer;

		if(restart)
		   if(Input.GetKeyDown(KeyCode.Return)) //KeyCode.Return = Enter Key 
		      Application.LoadLevel (Application.loadedLevel);
    }

    
    IEnumerator SpawnWaves(){

		yield return new WaitForSeconds(startTime);
		while(true){
			for(int i=0; i<hazardLoop; i++){
				Vector3 spawnPos = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		        Quaternion spawnRotate = Quaternion.identity;
				Instantiate (hazard, spawnPos, spawnRotate);
				
				if(count%15==0)
				   Instantiate(yellowHazard, spawnPos, spawnRotate);

				if(count%18==0)
				   Instantiate(redHazard, spawnPos, spawnRotate);

				if(count%30==0)
			       Instantiate(Star, spawnPos, spawnRotate);

				if(count%45==0)
				   WaveTime();
				

				yield return new WaitForSeconds(spawnTime);
            }
			yield return new WaitForSeconds(waveTime);

			if(gameOver){
				restartText.text = "Press 'Enter' To Restart";
				restart = true;
				break;
            }
		}
	}


	public void AddScore(int newScoreValue){
            score += newScoreValue;
			UpdateScore();
    }

	public void WaveTime(){

		waveTime/=10;
	}

	void UpdateScore(){
        scoreText.text = "Score: " + score;
	}

	public void GameOver(){

		gameOverText.text = "Game Over";
		gameOver = true;
    }
}
