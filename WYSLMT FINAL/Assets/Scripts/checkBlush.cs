using UnityEngine;
using System.Collections;

public class checkBlush : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;
	
	void Start(){
		
		datePoses = GameObject.Find ("Date").GetComponent<Animator>();
			
	}

	public void checkB() {

		if (GameObject.Find ("Date").GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Glasses1")) {
			
			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter> ().updateScore(1);
			datePoses.SetInteger ("State", Random.Range (1, 4));
			
		} else {
			
			Debug.Log ("Score-1");
			counter.GetComponent<scoreCounter> ().updateScore(-1);
			datePoses.SetInteger ("State", Random.Range (1, 4));
		}
	
		
		}

}
