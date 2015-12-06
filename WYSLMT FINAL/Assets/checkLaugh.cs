using UnityEngine;
using System.Collections;

public class checkLaugh : MonoBehaviour {
	

	public void checkL() {

		if (GameObject.Find ("Date").GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Wink")) {

			Debug.Log ("score+1");

		} else {

			Debug.Log ("Score-1");
		}

	}
}
