using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goToAnimation : MonoBehaviour {

	public GameObject date;


	public void finalMove(){

		if (date.tag == "Hasibe") {

			Application.LoadLevel ("Middle Scene");
		}

		if (date.tag == "Gui") {

			Application.LoadLevel("Gui Middle Scene");

		}

		if (date.tag == "Nicki") {

			Application.LoadLevel("Nicki Middle Scene");

		}

	}
}
