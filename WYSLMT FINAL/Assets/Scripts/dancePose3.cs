﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dancePose3 : MonoBehaviour {

	public Slider scoreCounter;
	int difficulty;
	public GameObject ScoreUp;
	public GameObject ScoreDown;
	public GameObject Heart;
	public GameObject HeartD;
	public GameObject particle;
	public GameObject butPos;
	
	
	public void scoreUp(){

		Debug.Log ("pressed3");

		if (scoreCounter.value >= 75) {
			difficulty = 15;
			Instantiate (ScoreUp, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position + new Vector3 (.8f, .5f, 0), GameObject.Find ("heartPos2").transform.rotation);
			Instantiate (Heart, GameObject.Find ("heartPos2").transform.position + new Vector3 (0, 1, 0), GameObject.Find ("heartPos2").transform.rotation);
			Instantiate (particle, butPos.transform.position, Quaternion.identity);
			
		} else {
			difficulty = -5;
			Instantiate (ScoreDown, GameObject.Find ("heartPos").transform.position, GameObject.Find ("heartPos").transform.rotation);
			Instantiate (HeartD, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
		}
		
		scoreCounter.value = scoreCounter.value + difficulty;
		
		
	}
}
