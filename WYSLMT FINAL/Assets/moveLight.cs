using UnityEngine;
using System.Collections;

public class moveLight : MonoBehaviour {

	public float speed = 1.0f;
	float percentage;
	float direction = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		percentage += Time.deltaTime / speed * direction;

		gameObject.transform.position = Vector3.Lerp (GameObject.Find("pos1").transform.position, GameObject.Find("pos2").transform.position, percentage);

		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp(percentage, 0, 1);
		}
	
	}
}
