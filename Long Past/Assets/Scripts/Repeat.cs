using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Repeat : MonoBehaviour {
	float startTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			startTime = Time.time;
//			timeStamp += Time.deltaTime;
		}

		if (Input.GetMouseButton (0)) {
			if (Time.time - startTime >= 5f) {
				SceneManager.LoadScene("Startup");
			}
		}

		if (Input.GetMouseButtonUp (0)) {
			startTime = 0;
		}
			
	}
}
