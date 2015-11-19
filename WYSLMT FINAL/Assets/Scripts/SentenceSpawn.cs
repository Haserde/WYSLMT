using UnityEngine;
using System.Collections;

public class SentenceSpawn : MonoBehaviour {

	public float score;

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;

	void Start () {

		levelCheck();
		score = 0;
	}

	void Update () {

		print (score);

	}
	
	public void levelCheck(){
		if (score == 3) {
			print ("Done");
			level1.SetActive (false);
			level2.SetActive (true);
		}
		if (score == 8) {
			print ("Done");
			level2.SetActive (false);
			level3.SetActive (true);
		}
		if (score == 12){
			print("Done");
			level3.SetActive (false);
			level4.SetActive(true);
		}
		if (score == 18){
			print ("Done" );
			level4.SetActive(false);
			level5.SetActive(true);
		}			
	}
}

