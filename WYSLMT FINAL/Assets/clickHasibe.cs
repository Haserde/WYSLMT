using UnityEngine;
using System.Collections;

public class clickHasibe : MonoBehaviour {

	public GameObject Talk;

	void Start(){

//		Talk.transform.gameObject.SetActive (false);

	}

	public void OnMouseDown(){

		Debug.Log ("hey");

		GameObject.Find ("Canvas").gameObject.transform.Find ("Hasi").transform.gameObject.SetActive (true);

	}
}
