using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goToAnimation : MonoBehaviour {


	public void finalMove(){

		GameObject.Find ("Canvas").gameObject.transform.Find ("Message").gameObject.SetActive (true);

	}
}
