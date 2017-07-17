using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour {

	static Musicplayer instance = null;
	// Use this for initialization
	void Awake () {
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructed");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
