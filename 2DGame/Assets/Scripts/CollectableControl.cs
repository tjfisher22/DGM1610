using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableControl : MonoBehaviour {
	
	int arrowUI = 0;


	//This one is needed for easier referencing when it's generic
	//The prefab will just have the same SO twice.3
	public Collectable pickUp;
	//These are needed for the specific send functions
	//If there is a way to reference the children of pickUp let me know
	//As in I can access all the variables declared in pickUP but can't get the chilren values
	//I could merge the classes but that's against SRP right? It'll make code management harder
	public Coin coin;
	public Arrow arrow;
	//Implement when SO are written
	
	//public PowerUp pUp;
	//public Potion pot;	
	
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
		//I should move the destroy functions to the individual classes, but will
		//that work since they are scriptable objects?
		if (other.gameObject.CompareTag("Player")){
			 gameObject.SetActive(false);
			 switch (pickUp.cType){
				 case Collectable.CollectableType.Coin:
				 	GameControl.instance.PlayerCoins(coin.coValue);
					break;
				case Collectable.CollectableType.Arrow:
					GameControl.instance.PlayerArrows(pickUp.cAmount,arrow.aType,arrowUI);
					break;
				default:
					Debug.Log("Collectable has no type");
					break;
			 }

		}

	}


}
