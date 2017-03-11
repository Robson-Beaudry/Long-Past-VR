using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class lightsOn1 : MonoBehaviour {
	public GameObject thisLight;

	// Use this for initialization
	void Start () {
//		myLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void letThereBeLight(){
		thisLight.SetActive(true);
	}

	public void andThereWasnt(){
		thisLight.SetActive(false);
	}
		
}
