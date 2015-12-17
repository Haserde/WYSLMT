using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose : MonoBehaviour {
	
	public Slider scoreCounter;
	int difficulty;
	public GameObject ScoreUp;
	public GameObject Heart;
	public GameObject HeartD;
	public GameObject particle;
	public GameObject butPos;


	public void scoreUp(){

		Debug.Log ("pressed");



		if (scoreCounter.value >= 0 && scoreCounter.value < 40) {

			difficulty = 5;
	
			Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
			Instantiate (particle, butPos.transform.position, Quaternion.identity);


		}

		if (scoreCounter.value >= 41) {
			difficulty = -7;
			Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (HeartD, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);

		}

		scoreCounter.value = scoreCounter.value + difficulty;

	}


}



	