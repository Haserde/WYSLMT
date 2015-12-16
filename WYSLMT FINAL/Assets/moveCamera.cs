using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {

	public int xMove = 1;
	public int Boundary = 50;
	public int speed = 5;

	private int theScreenWidth;
	private int theScreenHeight;

	// Use this for initialization
	void Start () {
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.mousePosition.x > theScreenWidth - Boundary) {
			transform.position.x += speed * Time.deltaTime;
		}
		if (Input.mousePosition.x < 0 + Boundary) {
			transform.position.x -= speed * Time.deltaTime;
		}
		if (Input.mousePosition.y > theScreenHeight - Boundary) {
			transform.position.y += speed * Time.deltaTime;
		}
		if (Input.mousePosition.y < 0 + Boundary) {
			transform.position.y -= speed * Time.deltaTime;
		}
	}*/






		/*if(Input.GetKeyDown(KeyCode.A)){
		transform.position = transform.position + new Vector3 (-xMove, 0, 0);

		}

		if (Input.GetKeyDown(KeyCode.D)){
		transform.position = transform.position + new Vector3 (xMove, 0, 0);
		
		}*/
	}
}
