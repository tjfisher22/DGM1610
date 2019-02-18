﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(CharControl.instance.scrollSpeed,0);
		Debug.Log(CharControl.instance.scrollSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
