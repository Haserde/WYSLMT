using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {

	public int xMove = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.A)){
		transform.position = transform.position + new Vector3 (-xMove, 0, 0);

		}

		if (Input.GetKeyDown(KeyCode.D)){
		transform.position = transform.position + new Vector3 (xMove, 0, 0);
		
		}

	}
}
