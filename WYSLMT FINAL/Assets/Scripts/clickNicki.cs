﻿using UnityEngine;
using System.Collections;

public class clickNicki : MonoBehaviour {

	public GameObject Talk;
	
	void Start(){
		
		//		Talk.transform.gameObject.SetActive (false);
		
	}
	
	void Update(){
		
	}
	
	public void OnMouseDown(){
		
		Application.LoadLevel ("Nicki Talking Scene");
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