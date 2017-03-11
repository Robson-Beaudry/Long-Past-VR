using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticePuller : MonoBehaviour {
	public GameObject target;
	Vector3 currentPos;
	bool isLooking;
	public float speed;
	public float howClose;
	float distance;

	// Use this for initialization
	void Start () {
		isLooking = false;
		currentPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (transform.position, target.transform.position);
		if (distance < howClose){
			isLooking = false;
		}
		if (isLooking && Time.time < 160) {
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .03f);
		}
	}
		

	public void pull(){
		isLooking = true;
	}


	public void push(){
		isLooking = false;
		transform.position = currentPos;
	}	

}
