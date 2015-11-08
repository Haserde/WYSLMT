using UnityEngine;
using System.Collections;

public class ThreeWP : MonoBehaviour {

	public string theThings;
	
	void OnTriggerEnter(Collider other) {
		if ( other.name == theThings) {
			GetComponent<MovementScript> ().enabled = false;
		}
	}
}
