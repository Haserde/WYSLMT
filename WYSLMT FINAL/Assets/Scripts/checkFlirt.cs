using UnityEngine;
using System.Collections;

public class checkFlirt : MonoBehaviour {

	Animator datePoses;
	public GameObject counter;
	public GameObject date;
	public GameObject particles;
	public GameObject butPos;
	public GameObject particlesDown;
	public AudioSource kiss;


	void Start(){
		
		datePoses = date.GetComponent<Animator>();
		kiss = kiss;
		
	}
	
	
	public void checkL() {
		
		if (date.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Flirt")) {
			
			Debug.Log ("score+1");
			counter.GetComponent<scoreCounter>().updateScore(1);
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			Instantiate(particles, butPos.gameObject.transform.position, Quaternion.identity);
			//kiss.Play ();
			
		} else {
			
			Debug.Log ("Score-1");
			date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));
			counter.GetComponent<scoreCounter> ().updateScore(-1);
			Instantiate(particlesDown, butPos.transform.position, Quaternion.identity);
			//kiss.Play ();
		}
		
	}
}
