using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class MovementScript : MonoBehaviour {

	public float speed;
	public Boundary boundary;

	Vector3 moveDirection;

	Vector3 screenPoint;
	Vector3 offset;

	private AudioSource pop;


	void Start() {
		Vector3 startDir = Random.insideUnitSphere;
		moveDirection = new Vector3 (startDir.x, startDir.y, 0);
		//print (moveDirection);
		pop = GetComponent<AudioSource> ();
	}

	void FixedUpdate () {
		transform.position = transform.position + moveDirection * speed * Time.deltaTime;
//		Vector3.Reflect ();

		//reflect off the sides of the screen
		if ( (transform.position.x > boundary.xMax) || (transform.position.x < boundary.xMin)) {
			moveDirection = new Vector3 ( -moveDirection.x, moveDirection.y, moveDirection.z );
		}

		if ( (transform.position.y > boundary.yMax) || (transform.position.y < boundary.yMin)) {
			moveDirection = new Vector3 (moveDirection.x, -moveDirection.y, moveDirection.z );
		}
	/*	if ((transform.position.z > boundary.zMax) || (transform.position.z < boundary.zMin)) {
			moveDirection = new Vector3 (moveDirection.z, moveDirection.y, -moveDirection.z);
		}*/

		transform.position = new Vector3  (
				Mathf.Clamp (transform.position.x, boundary.xMin, boundary.xMax), 
				Mathf.Clamp (transform.position.y, boundary.yMin, boundary.yMax), 
				0 );

	}
	void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint(GetComponent<Collider>().transform.position);
		offset = GetComponent<Collider>().transform.position - 
			Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		pop.Play ();

	}
	
	void OnMouseDrag() {
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) - offset;
		transform.position = curPosition;
		
	}

}


