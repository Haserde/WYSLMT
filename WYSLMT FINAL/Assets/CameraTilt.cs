using UnityEngine;
using System.Collections;

public class CameraTilt : MonoBehaviour {

	public float rotSpeed;

	void Start(){
		rotSpeed = rotSpeed;
	}

	void Update(){
		transform.Rotate (0,0, rotSpeed * Time.deltaTime, Space.World);
	}
	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "box") {
			rotSpeed = -rotSpeed;
		}
	}
}
