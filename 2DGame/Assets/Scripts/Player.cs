using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject {
	
	public int health;
	public int strength;
	public int jumpHeight;

	public int[] numArrows = new int[3];
	public int selectedArrow = 0;

	public float speed;

	public Sprite charSprite;

	public new string name;




	public int getHealth(){
		return health;
	}

	public void printStatus(){
		Debug.Log(name + ": has a strength of " + strength + " and current health of " + health);
	}



}
