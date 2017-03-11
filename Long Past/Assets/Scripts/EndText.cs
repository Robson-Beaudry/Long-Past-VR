using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 225){
			transform.position = GameObject.Find("Tele3").transform.position;
		}
	}
}
