using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newPoses : MonoBehaviour {

	public Slider scoreSlider;
	float speed = 0.075f;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreSlider.value > 30 && scoreSlider.value < 80) {

			Invoke ("scoreDown", 1);

		} else if (scoreSlider.value > 80 && scoreSlider.value < 100) {

			Invoke ("scoreDown", 0.1f);

		}


	}

	void scoreDown(){

		scoreSlider.value -= speed;

	}
}
