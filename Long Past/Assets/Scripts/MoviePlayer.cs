using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlayer : MonoBehaviour {
	public Texture[] textures;
	public float secondsToSwitch = 0.7f;
	Renderer rend;
	float counter = 0;
	int textureCounter = 0;
	//	Material currentTex = Renderer.material;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update () {
		TheCycler ();
	}

	public void TheCycler(){
		if (textureCounter > 49) {
			textureCounter = 0;
		}
		counter += Time.deltaTime;
		if (counter > secondsToSwitch) {
			rend.material.mainTexture = textures[textureCounter];
			counter = 0f;
			textureCounter++;
		}
	}
}