using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Platform", menuName = "Platform")]

public class Platform : ScriptableObject {

	public float xSpeed;
	public float ySpeed;
	public float xDist;
	public float yDist;

	public string name;

	public Sprite charSprite;

	//add stuff about prefabs here? 
	//also add box colliders to this if possible.

	
}
