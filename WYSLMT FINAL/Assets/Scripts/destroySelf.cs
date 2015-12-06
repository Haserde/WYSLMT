using UnityEngine;
using System.Collections;

public class destroySelf : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Invoke ("DestroySelf", .3f);
	
	}
	
	// Update is called once per frame
	void Update () {
	


	
	}

	void DestroySelf(){

		Destroy (gameObject);

	}
}
