using UnityEngine;
using System.Collections;

public class checkLaugh : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;

	void Start(){

		datePoses = GameObject.Find ("Date").GetComponent<Animator>();

	}
	

	public void checkL() {

		if (GameObject.Find ("Date").GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Wink")) {

			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter>().updateScore(1);
			datePoses.SetInteger("State", Random.Range(1,3));

		} else {

			Debug.Log ("Score-1");
			datePoses.SetInteger("State", Random.Range(1,3));
			counter.GetComponent<scoreCounter> ().updateScore(-1);
		}

	}
}
