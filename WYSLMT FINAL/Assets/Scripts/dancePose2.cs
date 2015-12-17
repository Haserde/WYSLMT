using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose2 : MonoBehaviour {

	public Slider scoreCounter;
	int difficulty;
	public GameObject ScoreUp;
	public GameObject ScoreDown;
	public GameObject Heart;
	public GameObject HeartD;
	
	
	public void scoreUp(){

		difficulty = 1;
		
		Debug.Log ("pressed2");
		

		
		if (scoreCounter.value >= 30 && scoreCounter.value <= 100) {
			difficulty = 10;
			Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position + new Vector3 (.8f, .5f, 0), GameObject.Find ("heartPos2").transform.rotation);
			
		} else {
			difficulty = -7;
			Instantiate (ScoreDown, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (HeartD, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);

		}
		
		scoreCounter.value = scoreCounter.value + difficulty;
		
		
	}
}
