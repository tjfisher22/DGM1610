using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

	public Player player;
	public Enemy enemy;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		 	if (other.gameObject.name == "Char"){
				 player.health -= enemy.strength;
     	}
	 }
}
