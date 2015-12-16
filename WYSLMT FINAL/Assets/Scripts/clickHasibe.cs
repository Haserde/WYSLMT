using UnityEngine;
using System.Collections;

public class clickHasibe : MonoBehaviour {

	public GameObject Talk;

	void Start(){

//		Talk.transform.gameObject.SetActive (false);

	}

	public void OnMouseDown(){

		Debug.Log ("hey");

		Talk.gameObject.SetActive (true);

	}
}
