using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : ScriptableObject {
	//enum CollectableType {Coin, Arrow, PowerUp, Potion};

	public string cName = "New Collectable";
	public Sprite cSprite;
	public int cAmount;
	//public CollectableType cType;

	public abstract void Initialize(GameObject obj);
	public abstract void Spawn();
}
