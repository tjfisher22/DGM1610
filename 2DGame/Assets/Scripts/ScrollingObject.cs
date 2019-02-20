﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed,0);
		Debug.Log(GameControl.instance.scrollSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
