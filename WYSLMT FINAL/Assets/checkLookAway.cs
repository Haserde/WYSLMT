using UnityEngine;
using System.Collections;

public class checkLookAway : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;
	public GameObject date;
	
	void Start(){
		
		datePoses = date.GetComponent<Animator>();
		
	}
	
	
	public void checkL() {
		
		if (date.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Look Away")) {
			
			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter>().updateScore(1);
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			
		} else {
			
			Debug.Log ("Score-1");
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			counter.GetComponent<scoreCounter> ().updateScore(-1);
		}
		
	}
}
