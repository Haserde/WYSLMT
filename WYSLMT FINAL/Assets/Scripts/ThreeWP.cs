using UnityEngine;
using System.Collections;

public class ThreeWP : MonoBehaviour {

	public string theThings;
	
	void OnTriggerEnter(Collider other) {
		print ("here");
		if (other.name == theThings) {
			other.GetComponent<MovementScript> ().enabled = false;
			//other.transform.position = transform.position;
			other.GetComponent<Rigidbody>().Sleep();
		}
	}
}