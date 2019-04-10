using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Collectables/Coin")]
public class Coin : Collectable {

	public Color coinColor = Color.black;
	public int coValue;
	//public Sprite cSprite;

	private SpriteRenderer collectSprite;

	//private CollectableControl coinSpawn;

	public override void Initialize(GameObject obj){
		//coinSpawn = obj.GetComponent<CollectableControl> ();
		//coinSpawn.Initialize ();
		collectSprite = obj.GetComponent<SpriteRenderer> ();
		collectSprite.sprite = cSprite;
		collectSprite.color = coinColor;
		collectSprite.sortingOrder = 100;



	}
	public override void Spawn(){

		//Rigidbody2D coin = (Rigidbody2D) Instantiate(CollectableBody, transform.position + (transform.forward*2), transform.rotation);
	}
}
