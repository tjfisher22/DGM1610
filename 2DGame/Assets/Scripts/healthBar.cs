using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {

	private Transform bar;
	
	public Player player;


	// Use this for initialization
	void Start () {
		bar = transform.Find("Bar");
	}
	
	void Update(){
		bar.localScale = new Vector2(player.health/100f,1f);
	}
}
