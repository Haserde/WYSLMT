using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SentenceSpawn : MonoBehaviour {

	public float score;

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;
	public GameObject date;
	private GameObject cam;
	public AudioSource DrinkPour;
	public AudioSource Ice;

	public Button buttonText;




	void Start () {

		levelCheck ();
		score = 0;
		cam = GameObject.Find ("Main Camera");
		DrinkPour = DrinkPour;
		Ice = Ice;
		date = date;
	}


	void Update () {
		print (score);
	}


	public void levelCheck(){
		if (score == 3) {
			print ("Done");
			level1.SetActive (false);
			level2.SetActive (true);
			cam.GetComponent<CameraTilt> ().rotSpeed = 3;
			cam.GetComponent<UnityStandardAssets.ImageEffects.BlurOptimized>().blurIterations += 1;
			DrinkPour.Play ();
			Ice.Play ();
		}

		if (score == 7) {
			print ("Done");
			level2.SetActive (false);
			level3.SetActive (true);
			cam.GetComponent<CameraTilt>().rotSpeed = 7;
			DrinkPour.Play ();
			Ice.Play ();
		}

		if (score == 12){
			print("Done");
			level3.SetActive (false);
			level4.SetActive(true);
			cam.GetComponent<CameraTilt>().rotSpeed = 12;
			DrinkPour.Play ();
			Ice.Play ();
		}

		if (score == 18){
			print ("Done" );
			level4.SetActive(false);
			level5.SetActive(true);
			cam.GetComponent<CameraTilt>().rotSpeed = 18;
			DrinkPour.Play ();
			Ice.Play ();
			buttonText.gameObject.transform.Find("Text").gameObject.SetActive(false);
			buttonText.gameObject.transform.Find("Text2").gameObject.SetActive(true);
		}

		if (score == 24) {

			//Application.LoadLevel("Dancing Game");
			if (date.tag == "Gui") {
				Application.LoadLevel ("Gui Dancing Scene");
			}
			if (date.tag == "Nicki") {
				Application.LoadLevel ("Nicki Dancing Scene");
			}
			if (date.tag == "Hasibe") {
				Application.LoadLevel ("Dancing Game");
			}
		}
	}
}

