using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose3 : MonoBehaviour {

	public Slider scoreCounter;
	int difficulty;
	
	
	public void scoreUp(){
		
		Debug.Log ("pressed3");

		
		scoreCounter.value = scoreCounter.value + difficulty;
		
		if (scoreCounter.value >= 75) {
			difficulty = 5;
			
		} else {
			difficulty = -3;
		}
		
		
		
		
	}
}
