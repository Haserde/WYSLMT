using UnityEngine;
using System.Collections;

public class ThreeWP : MonoBehaviour {

	public string theThings;
	public GameObject level;

	void Start (){

	}
	
	void OnTriggerEnter(Collider other) {
		print ("here");
		if (other.name == theThings) {
			other.GetComponent<MovementScript> ().enabled = false;
			//other.transform.position = transform.position;
			level.GetComponent<SentenceSpawn>().score += 1;
			other.GetComponent<Rigidbody>().Sleep();
		}
	}
}