using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clickHasibe : MonoBehaviour {

	public GameObject Talk;

	void Start(){

//		Talk.transform.gameObject.SetActive (false);

	}

	void Update(){

	}

	public void OnMouseDown(){

		Application.LoadLevel ("Talking Game");
		Debug.Log ("hey");

	}

	void OnMouseEnter(){

		Debug.Log ("sup");
		Talk.gameObject.SetActive (true);
	}

	void OnMouseExit(){

		Talk.gameObject.SetActive (false);

	}


}
