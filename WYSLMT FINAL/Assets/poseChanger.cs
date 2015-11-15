using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class poseChanger : MonoBehaviour {
	
	Animator changePose;
	public Slider slider;
	public GameObject TextWarning;
	public GameObject EndDance;


	void Start () {

		changePose = GetComponent<Animator> ();
	
	}

	void Update () {

		if (slider.value >= 20 && slider.value < 75) {

			changePose.SetInteger ("State", 1);
			Instantiate (TextWarning, GameObject.Find ("textPos").transform.position, GameObject.Find ("textPos").transform.rotation);
		

		} else if (slider.value >= 75) {
			changePose.SetInteger ("State", 0);

		} else {
			changePose.SetInteger("State", 3);
		}
	
	}

}
