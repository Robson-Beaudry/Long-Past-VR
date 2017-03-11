using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {
	Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.value;
		if (x > 0.8f) {
			myLight.enabled = false;
		} 
		else {
			myLight.enabled = true;
		}
	}
}
