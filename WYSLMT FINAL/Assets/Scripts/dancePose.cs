using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose : MonoBehaviour {
	
	public Slider scoreCounter;
	int difficulty;
	public GameObject ScoreUp;
	public GameObject Heart;


	public void scoreUp(){

		Debug.Log ("pressed");

		scoreCounter.value = scoreCounter.value + difficulty;

		difficulty = 1;
	
		Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
		Instantiate (Heart, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);

	}


}



	