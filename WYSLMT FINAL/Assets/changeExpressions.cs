using UnityEngine;
using System.Collections;

public class changeExpressions : MonoBehaviour {

	Animator datePoses;

	// Use this for initialization
	void Start () {

		datePoses = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {

			datePoses.SetInteger("State", 2);

		}

	

	
	}
}
