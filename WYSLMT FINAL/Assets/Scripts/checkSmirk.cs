using UnityEngine;
using System.Collections;

public class checkSmirk : MonoBehaviour {

	public GameObject counter;
	public GameObject date;
	public GameObject particles;
	public GameObject butPos;
	
	void Start(){
		
	}
	
	
	public void checkL() {
		
		if (date.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Smirk")) {
			
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
