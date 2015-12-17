using UnityEngine;
using System.Collections;

public class moveKeyCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.A)) {

			transform.position = transform.position + new Vector3 (-1, 0, 0);

		} else if (Input.GetKeyDown (KeyCode.D)) {

			transform.position = transform.position + new Vector3 (1,0,0);

		}
	
	}
}
