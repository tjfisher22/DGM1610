using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour {

	public Player player;
	public Rigidbody2D arrow;
	public Vector2 speed;
	private SpriteRenderer arrowSprite;
	public Sprite[] arrowSprites = new Sprite[3];

	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.F)){
			Fire();
			

		}
	}
	void Fire(){
		if(player.numArrows[player.selectedArrow]>0){
		Debug.Log("Fire");
		Rigidbody2D arrowClone = (Rigidbody2D) Instantiate(arrow, transform.position + (transform.forward*2), transform.rotation);
		arrowClone.velocity = speed;
		player.numArrows[player.selectedArrow]--;
		GameControl.instance.ArrowUI(player.selectedArrow);
		arrowSprite = arrowClone.GetComponent<SpriteRenderer>();
		arrowSprite.sprite = arrowSprites[player.selectedArrow];
		coroutine = DestroyArrow(arrowSprite);
		StartCoroutine(coroutine);
		}
		else {Debug.Log("No Arrow?");}
		//use player.selectedArrow to change sprite
		
	}

	IEnumerator DestroyArrow(SpriteRenderer arrow){

		//slow down arrow mid flight
		// for (float f = 10f; f >= 0; f -= 1f) {
		// 	arrow.GetComponent<Rigidbody2D>().velocity = new Vector2(arrow.GetComponent<Rigidbody2D>().velocity.x-f,arrow.GetComponent<Rigidbody2D>().velocity.y-f);
  
        // 	yield return new WaitForSeconds(1f);
    	// }	

		yield return new WaitForSeconds(1f);
		arrow.enabled = false;

	}
}
