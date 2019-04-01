using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Collectables/Arrow")]
public class Arrow : Collectable {

	//not working here when tryying to pass parent class
	// public enum ArrowType {Normal, Ice, Fire};

	// public ArrowType aType = ArrowType.Normal;
	private SpriteRenderer collectSprite;

	//private CollectableControl coinSpawn;

	public override void Initialize(GameObject obj){
		//coinSpawn = obj.GetComponent<CollectableControl> ();
		//coinSpawn.Initialize ();
		collectSprite = obj.GetComponent<SpriteRenderer> ();
		collectSprite.sprite = cSprite;
		collectSprite.sortingOrder = 100;
	}
	public void AddArrow(int amount, GameObject obj){
		


	}
	public override void Spawn(){
	}

}
