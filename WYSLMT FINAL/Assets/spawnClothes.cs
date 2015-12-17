using UnityEngine;
using System.Collections;

public class spawnClothes : MonoBehaviour {


	public GameObject clothesToSpawn;
	public GameObject place;
	public int timer;


	// Use this for initialization
	void Start () {

		Invoke ("clothesS", timer);
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void clothesS(){

		Instantiate (clothesToSpawn, place.gameObject.transform.position, Quaternion.identity);

	}
}
