using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour {

	public Platform plat;
	bool left;
	bool up;

	// Use this for initialization
	void Start () {
		up = left = true;
	}
	
	// Update is called once per frame
	void Update () {
		movePlat();
	}
	void movePlat(){
		//if()
		GetComponent<Rigidbody2D>().velocity = new Vector2(plat.xSpeed,plat.ySpeed);
	}
}
