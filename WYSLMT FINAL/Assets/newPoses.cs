using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newPoses : MonoBehaviour {


	public GameObject finishMove;
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

		if (scoreSlider.value == 100) {
			Debug.Log ("button created");
//			Instantiate (finishMove, GameObject.Find ("heartPos2").transform.position, GameObject.Find ("heartPos2").transform.rotation);
		}


	}

	void scoreDown(){

		scoreSlider.value -= speed;

	}
}
