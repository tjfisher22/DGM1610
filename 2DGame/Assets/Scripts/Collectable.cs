using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : ScriptableObject {
	public enum CollectableType {Coin, Arrow, PowerUp, Potion};

	public string cName = "New Collectable";
	public Sprite cSprite;
	public int cAmount;
	public int cValue;
	public CollectableType cType;

	//public Arrow arrow;

	public enum ArrowType {Normal, Ice, Fire, Null};

	public ArrowType aType = ArrowType.Null;

	public abstract void Initialize(GameObject obj);
	public abstract void Spawn();
}
