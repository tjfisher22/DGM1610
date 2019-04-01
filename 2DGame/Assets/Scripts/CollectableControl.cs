using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableControl : MonoBehaviour {
	public Collectable pickUp;
	int arrowUI = 0;
	//public Coin coin;
	//Implement when SO are written
	//public Arrow arrow;
	// public PowerUp pUp;
	// public Potion pot;	
	
	//[HideInInspector]
	//public SpriteRenderer collectSprite;
	//public GameObject obj;
	void Start(){
		Initialize();
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			if(arrowUI>0)arrowUI--;
			else arrowUI = 2;
			GameControl.instance.ArrowUI(arrowUI);
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			if(arrowUI<2)arrowUI++;
			else arrowUI = 0;
			GameControl.instance.ArrowUI(arrowUI);
		}

		
	}

	public void Initialize (){

		//get and store a refernece to the SpriteRenderer component
		// collectSprite = GetComponent<SpriteRenderer> ();
		pickUp.Initialize(gameObject);
		GameControl.instance.ArrowUI(arrowUI);


	}
	public void Spawn(){
		

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")){
			 gameObject.SetActive(false);
			 switch (pickUp.cType){
				 case Collectable.CollectableType.Coin:
				 	GameControl.instance.PlayerCoins(pickUp.cValue);
					break;
				case Collectable.CollectableType.Arrow:
					GameControl.instance.PlayerArrows(pickUp.cAmount, pickUp.aType,arrowUI);
					break;
				default:
					Debug.Log("Collectable has no type");
					break;
			 }

		}

	}


}
