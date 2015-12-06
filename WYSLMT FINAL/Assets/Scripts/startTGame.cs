using UnityEngine;
using System.Collections;

public class startTGame : MonoBehaviour {

	Animator datePoses;

	void Start(){

		datePoses = GameObject.Find ("Date").GetComponent<Animator>();

	}

	public void startGame(){

		datePoses.SetInteger("State", Random.Range(1,3));

	}

	public void destroySelf(){

		GameObject.Find("Canvas").gameObject.transform.Find("Black Shade").gameObject.SetActive(false);

		Destroy (gameObject);

	}
	
}
