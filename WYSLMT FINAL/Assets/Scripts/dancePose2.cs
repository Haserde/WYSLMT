using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose2 : MonoBehaviour {

	public Slider scoreCounter;
	int difficulty;
	
	
	public void scoreUp(){
		
		Debug.Log ("pressed2");
		
		scoreCounter.value = scoreCounter.value + difficulty;
		
		if (scoreCounter.value >= 20) {
			difficulty = 2;
			
		} else {
			difficulty = -1;
		}
		
		
		
		
	}
}
