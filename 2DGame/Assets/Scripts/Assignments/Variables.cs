using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
//is the comment part of the assignment?
/* I'll make two comments
just in case it is*/
	public int number;
	public float speed;
	public string name;
	public int age;

	// Use this for initialization
	void Start () {
		number = 0;
		age = 20;
		speed = 0.1f;
		name = "Steve";

		print(name+" is "+number+" years old");
		name = "Susan";
		print("But "+name+" is "+age+" years old");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(speed,0,0);
		
	}
}
