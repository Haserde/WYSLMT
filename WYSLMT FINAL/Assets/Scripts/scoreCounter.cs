using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {

	private int score;

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;



	// Use this for initialization
	void Start () {
		score = 0;
	}

	public void updateScore ( int _amount) {
		score += _amount;
		if (score < 0) {
			score = 0;
			heart1.SetActive (false);
			heart2.SetActive (false);
			heart3.SetActive (false);

		} else if (score == 1) {

			heart1.SetActive (true);
			heart2.SetActive (false);
			heart3.SetActive (false);

		
		} else if (score == 2) {
			
			heart1.SetActive (true);
			heart2.SetActive (true);
			heart3.SetActive (false);


		} else if (score == 3) {
			heart1.SetActive (true);
			heart2.SetActive (true);
			heart3.SetActive (true);
			GameObject.Find ("Canvas").gameObject.transform.Find ("Congrats").gameObject.SetActive (true);

	
		} 

	
	}
}
