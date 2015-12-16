using UnityEngine;
using System.Collections;

public class startTGame : MonoBehaviour {

	Animator datePoses; 
	public GameObject date; 

	void Start(){

	}

	public void startGame(){

		date.GetComponent<Animator>().SetInteger("State", Random.Range(1,6));

	}

	public void destroySelf(){

		GameObject.Find("Canvas").gameObject.transform.Find("Black Shade").gameObject.SetActive(false);

		Destroy (gameObject);

	}
	
}
