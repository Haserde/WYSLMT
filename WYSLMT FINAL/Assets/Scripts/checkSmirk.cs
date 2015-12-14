using UnityEngine;
using System.Collections;

public class checkSmirk : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;
	
	void Start(){
		
		datePoses = GameObject.Find ("Date").GetComponent<Animator>();
			
	}

	public void checkS() {
		
		if (GameObject.Find ("Date").GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Glasses2")) {
			
			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter> ().updateScore(1);
			datePoses.SetInteger("State", Random.Range(1,3));

			
		} else {
			
			Debug.Log ("Score-1");
			counter.GetComponent<scoreCounter> ().updateScore(-1);
			datePoses.SetInteger ("State", Random.Range(1,3));
		}
		
	}
}
