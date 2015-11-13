using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose3 : MonoBehaviour {

	public Slider scoreCounter;
	int difficulty;
	public GameObject ScoreUp;
	public GameObject ScoreDown;
	public GameObject Heart;
	
	
	public void scoreUp(){
		
		Debug.Log ("pressed3");

		
		scoreCounter.value = scoreCounter.value + difficulty;
		
		if (scoreCounter.value >= 75) {
			difficulty = 5;
			Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
			
		} else {
			difficulty = -3;
			Instantiate (ScoreDown, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
		}
		
		
		
		
	}
}
