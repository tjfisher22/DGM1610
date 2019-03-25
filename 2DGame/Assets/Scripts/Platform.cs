using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Platform", menuName = "Platform")]

public class Platform : ScriptableObject {

	// public float xSpeed;
	// public float ySpeed;
	// public float xDist;
	// public float yDist;
	public bool up;
	public bool left;
	// public float xStart;
	// public float yStart;

	public Vector2 speed;
	public Vector2 distance;

	public string name;

	public Sprite charSprite;

	//add stuff about prefabs here? 
	//also add box colliders to this if possible.

	
}
