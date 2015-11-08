using UnityEngine;
using System.Collections;

public class ThreeWP : MonoBehaviour {

	public string[] sentence = {"I'm", "having", "fun!"};

	public string theThigns;
	
	void OnTriggerEnter(Collider other) {
		if ( other.name == theThigns) {
			//this is the right word
		}
	}
}
