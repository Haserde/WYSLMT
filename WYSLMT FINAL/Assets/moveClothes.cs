using UnityEngine;
using System.Collections;

public class moveClothes : MonoBehaviour {

	public float forceX = 0;
	public float forceY;
	public int orientation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		forceX += .1f;
		forceY += .2f;

		gameObject.GetComponent<Rigidbody> ().AddForce (.1f * orientation, forceY, 0);

//		if (forceX >= 2) {
//
//			forceX = 0;
//		} else if (forceY >= 3) {
//
//			forceY = 0;
//		}

		Destroy (gameObject, 4);
	
	}
}
