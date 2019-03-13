using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatformControl : MonoBehaviour {

	public Platform plat;
	public bool left;
	public bool up;
	

	// public float xStart;
	// public float yStart;

	static Vector2 platStart;
	Vector2 platPosition;

	// Use this for initialization
	void Start () {
		up = plat.up;
		left = plat.left;
		platStart = GetComponent<Rigidbody2D>().position;


	}
	
	// Update is called once per frame
	void Update () {
		movePlat(GetComponent<Rigidbody2D>().position);
	}
	void movePlat(Vector2 currentPos){
		float xSpeed = plat.speed.x;
		float ySpeed = plat.speed.y; 


		//going up and down and too far
		if(currentPos.y>Mathf.Abs(platStart.y-plat.yDist)){
			//If up is true, ie 1 -1^1 = -1 so it swaps speed to negative
			//If up is false, ie 0 -1^0 = 1 so it swaps speed to positive
			ySpeed = Mathf.Pow(-1f, Convert.ToInt32(up));
			up  = !up;
		}
		//for going up

		//for going down




		GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed,ySpeed);
	}
}
