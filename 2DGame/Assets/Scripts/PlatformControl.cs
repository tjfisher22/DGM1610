using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatformControl : MonoBehaviour {

	public Platform plat;
	public bool left;
	public bool up;
	
	// public float ySpeed;
	// public float xSpeed;
	// public float xDist;
	// public float yDist;
	
	Vector2 platDist;
	Vector2 platSpeed;

	// public float xStart;
	// public float yStart;

	static Vector2 platStart;
	Vector2 platPosition;

	// Use this for initialization
	void Start () {
		up = plat.up;
		left = plat.left;
		platStart = GetComponent<Rigidbody2D>().position;
		//xSpeed = plat.speed.x;
		//ySpeed = plat.speed.y; 
		platDist = plat.distance;
		platSpeed = plat.speed; 



	}
	
	// Update is called once per frame
	void Update () {
		movePlat(GetComponent<Rigidbody2D>().position, platDist, platSpeed);
	}
	void movePlat(Vector2 currentPos, Vector2 distance, Vector2 speed;)	{
		
		

		//going up and down and too far
		// if(currentPos.y>Mathf.Abs(platStart.y-plat.yDist)){
		// 	//If up is true, ie 1 -1^1 = -1 so it swaps speed to negative
		// 	//If up is false, ie 0 -1^0 = 1 so it swaps speed to positive
		// 	ySpeed = ySpeed * Mathf.Pow(-1f, Convert.ToInt32(up));
		// 	up  = !up;

		// }
		//for going up

		//for going down

		//Trying Math.PingPong, will try sine next

		//transform.position = new Vector3(Mathf.PingPong(currentPos.x,xDist),Mathf.PingPong(currentPos.y,yDist));

		






		GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed,ySpeed);
	}
}
