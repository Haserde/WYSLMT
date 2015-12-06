using UnityEngine;
using System.Collections;

public class SentenceSpawn : MonoBehaviour {

	public float score;

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;
	private GameObject cam;
	public AudioSource DrinkPour;
	public AudioSource Ice;

	void Start () {

		levelCheck();
		score = 0;
		cam = GameObject.Find ("Main Camera");
		DrinkPour = DrinkPour;
		Ice = Ice;
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
			//cam.GetComponent<BlurOptimized> ();
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
		}	
	}
}

