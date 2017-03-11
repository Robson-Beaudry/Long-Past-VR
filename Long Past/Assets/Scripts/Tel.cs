using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tel : MonoBehaviour {
	int counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && Time.timeSinceLevelLoad < 225){
			nextPlane ();

		}
	}

	void nextPlane(){
		counter += 1;
		transform.position = GameObject.Find("Tele"+ counter).transform.position;
		if (counter == 2) {
			counter = -1;
		}
	}
}
