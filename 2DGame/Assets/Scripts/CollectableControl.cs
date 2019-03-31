using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableControl : MonoBehaviour {

	public Coin coin;
	//Implement when SO are written
	public Arrow arrow;
	// public PowerUp pUp;
	// public Potion pot;	
	
	//[HideInInspector]
	//public SpriteRenderer collectSprite;
	//public GameObject obj;
	void Start(){
		Initialize();
	}

	public void Initialize (){

		//get and store a refernece to the SpriteRenderer component
		// collectSprite = GetComponent<SpriteRenderer> ();
		coin.Initialize(gameObject);


	}
	public void Spawn(){
		

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")){
			 gameObject.SetActive(false);
			 GameControl.instance.PlayerCoins(coin.cAmount);
			 GameControl.instance.PlayerArrows(arrow.cAmount);
		}

	}


}
