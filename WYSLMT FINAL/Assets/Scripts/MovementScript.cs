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
	Vector3 lastPosition;
	Vector3 moveDirection;

	void Start() {
		Vector3 startDir = Random.insideUnitSphere;
		moveDirection = new Vector3 (startDir.x, startDir.y,0);
	}

	void FixedUpdate () {
		transform.position = transform.position + moveDirection * speed * Time.deltaTime;
//		Vector3.Reflect ();

		lastPosition = transform.position;

		//reflect off the sides of the screen
		if ( (transform.position.x > boundary.xMax) || (transform.position.x < boundary.xMin)) {
			moveDirection = new Vector3 ( -moveDirection.x, moveDirection.y, 0);
		}

		if ( (transform.position.y > boundary.yMax) || (transform.position.y < boundary.yMin)) {
			moveDirection = new Vector3 (moveDirection.x, -moveDirection.y, 0);
		}

		/*transform.position = new Vector3  (
				Mathf.Clamp (transform.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (transform.position.y, boundary.yMin, boundary.yMax) );
*/
	}
}
