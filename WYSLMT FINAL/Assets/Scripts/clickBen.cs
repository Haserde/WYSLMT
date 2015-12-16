using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class clickBen : MonoBehaviour {

	public GameObject benButton;

	void OnMouseEnter(){
		benButton.gameObject.SetActive (true);

	}

	void OnMouseExit(){
		benButton.gameObject.SetActive (false);

	}
}
