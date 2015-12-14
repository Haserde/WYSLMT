using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class poseChanger : MonoBehaviour {
	
	Animator changePose;
	public Slider slider;
	public GameObject TextWarning;
	public GameObject EndDance;
	public GameObject TextWarning2;

	bool pose1;
	bool pose2;


	void Start () {

		changePose = GetComponent<Animator> ();

	
	}

	void Update () {

		if (slider.value >= 20 && slider.value < 75) {
			changePose.SetInteger ("State", 1);

			if(!pose1){
			Instantiate (TextWarning, GameObject.Find ("textPos").transform.position, GameObject.Find ("textPos").transform.rotation);
				pose1  = true;


			}

		} else if (slider.value >= 75) {
			changePose.SetInteger ("State", 2);

			if(!pose2){
			Instantiate (TextWarning2, GameObject.Find ("textPos").transform.position, GameObject.Find ("textPos").transform.rotation);
				pose2 = true;


			}

		} else {
			changePose.SetInteger("State", 0);
		}
	
	}

}
