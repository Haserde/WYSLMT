using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {

	void Start(){
	}

	void Update(){
			//transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
		float speed = 10f;
		transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f), transform.position.y, transform.position.z);
		}
}
