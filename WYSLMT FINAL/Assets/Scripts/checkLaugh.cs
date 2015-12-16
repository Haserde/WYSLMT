using UnityEngine;
using System.Collections;

public class checkLaugh : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;
	public GameObject date;
	public GameObject particles;
	public GameObject butPos;

	void Start(){

		datePoses = date.GetComponent<Animator>();

	}
	

	public void checkL() {

		if (date.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Laugh")) {

			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter>().updateScore(1);
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			Instantiate(particles, butPos.gameObject.transform.position, Quaternion.identity);

		} else {

			Debug.Log ("Score-1");
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			counter.GetComponent<scoreCounter> ().updateScore(-1);
		}

	}
}
