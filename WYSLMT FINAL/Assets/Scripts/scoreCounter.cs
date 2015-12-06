using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {

	public float score;

	// Use this for initialization
	void Start () {

		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (score < 0) {
			score = 0;
		}

		if (score >= 3) {

			GameObject.Find("Canvas").gameObject.transform.Find("Congrats").gameObject.SetActive(true);

		}
	
	}
}
