using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goToAnimation : MonoBehaviour {

	public GameObject date;


	public void finalMove(){

		if (date.tag == "Hasibe") {

			gameObject.GetComponent<AudioSource>().Play ();

			Invoke("loadHasibe", gameObject.GetComponent<AudioSource>().clip.length);
		}

		if (date.tag == "Gui") {

			Invoke("loadGui", gameObject.GetComponent<AudioSource>().clip.length);

			gameObject.GetComponent<AudioSource>().Play ();

		}

		if (date.tag == "Nicki") {

			gameObject.GetComponent<AudioSource>().Play ();
			Invoke("loadNicki", gameObject.GetComponent<AudioSource>().clip.length);

		}

	}

	void loadNicki(){

		Application.LoadLevel("Nicki Middle Scene");

	}

	void loadGui(){
		
		Application.LoadLevel("Gui Middle Scene");
		
	}

	void loadHasibe(){
		
		Application.LoadLevel("Middle Scene");
		
	}
}
