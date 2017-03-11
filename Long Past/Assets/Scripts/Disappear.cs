using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {
	//1:57 - 2:20
	public GameObject person;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 117 && Time.timeSinceLevelLoad < 141) {
			flickerExistence ();
		} 

		else if (Time.timeSinceLevelLoad > 140) {
			person.SetActive(false);
		}
	}

	void flickerExistence(){
		float x = Random.value;
		if (x > 0.8f) {
			person.SetActive(true);
		} 
		else {
			person.SetActive(false);
		}
	}
}
