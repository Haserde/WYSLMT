using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose : MonoBehaviour {
	
	public Slider scoreCounter;
	int difficulty;


	public void scoreUp(){

		Debug.Log ("pressed");

		scoreCounter.value = scoreCounter.value + difficulty;

		difficulty = 1;


	}

}



	