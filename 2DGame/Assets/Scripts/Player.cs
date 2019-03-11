using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject {
	
	public int health;
	public int strength;
	public int jumpHeight;
	
	public float speed;

	public Sprite charSprite;

	public new string name;


}
