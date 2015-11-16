using UnityEngine;
using System.Collections;

public class SentenceSpawn : MonoBehaviour {

	public GameObject [] prefabs;

	void onClick(){
		GameObject go = (GameObject) Instantiate(Resources.Load ("Level 1"));
	
	}
}
