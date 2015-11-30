using UnityEngine;
using System.Collections;

public class moveDown : MonoBehaviour {

	public float ySpeed = -0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = transform.position + new Vector3 (0, ySpeed, 0);
		Invoke ("destroySelf", 1f);
	
	}

	void destroySelf(){
		Destroy (gameObject);
	}
}
