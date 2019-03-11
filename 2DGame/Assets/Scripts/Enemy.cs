using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject {

	public int health;
	public int strength;
	
	//public float speed;

	public Sprite enemySprite;

	public new string name;
}
