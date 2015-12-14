using UnityEngine;
using System.Collections;

public class destroySelf : MonoBehaviour {

	public int delay = 1;

	// Use this for initialization
	void Start () {

		Invoke ("DestroySelf", .3f * delay);
	
	}
	
	// Update is called once per frame
	void Update () {
	


	
	}

	void DestroySelf(){

		Destroy (gameObject);

	}
}
