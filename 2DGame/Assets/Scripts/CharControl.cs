using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharControl : MonoBehaviour {

	public float jumpHeight;
	bool hasDoubleJump = false;
	bool grounded;


	public Player player;
	// Use this for initialization
	void Start () {
		//PowerUpDisplay("None");
		jumpHeight = player.jumpHeight;
		player.health = 100;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			if(grounded){
				Jump();
			}
			else{
				if(hasDoubleJump){
					hasDoubleJump = false;
					//Debug.Log("No Double");
					GameControl.instance.PowerUpDisplay("None");
					Jump();
				}
				//else{Debug.Log("OffGroundJumpTry");}
			} 
		}
		//debuging health control
		if(Input.GetKeyDown(KeyCode.P)){
			if(player.health > 0){
			player.health -= 10;
			}
		}
		if(Input.GetKeyDown(KeyCode.O)){
			if(player.health < 100){
			player.health += 10;
			}
		}
		// if(Input.GetKey(KeyCode.Space)&&!grounded&&hasDoubleJump){
			
		// }
		
		
		// if(speed<200f){
		//  speed+=10f;
		// }

	}
	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
	//Will this work later? As in will there be issues with it detecting other collisions. No, becasue it's only applied to the player char
	//Like the function detects when "Playerchar" or whatever this script is assigned to collides with something
	//When that something is slope the function runs.... I think
	void OnCollisionEnter2D(Collision2D collision){
		 //Debug.Log("Entered");
     	if (collision.gameObject.name == "Slope"){
         	grounded = true;
     	}
		 //moved to collectablecontrol
        // if (collision.gameObject.CompareTag("Collectable")){
        //     collision.gameObject.SetActive(false);
		// 	//GameControl.instance.PlayerCoins(collision.);
        //}

 	}
 
 
 	void OnCollisionExit2D(Collision2D collision) {
		 //Debug.Log("Exited");
     	if (collision.gameObject.name == "Slope"){
         	grounded = false;
     	}

 	}
	 //Should probably split power ups into their own script
	 void OnTriggerEnter2D(Collider2D other){
		 	if (other.gameObject.name == "PowerUp"){
         	hasDoubleJump = true;
			other.gameObject.SetActive(false);
			//Debug.Log("PowerUp");
			GameControl.instance.PowerUpDisplay("Double Jump");
     	}
	 }

}
