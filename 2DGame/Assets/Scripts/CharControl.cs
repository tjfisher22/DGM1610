using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharControl : MonoBehaviour {

	// public static CharControl instance;
	public float jumpHeight;
	// public float scrollSpeed = -5f;
	bool doubleJump = false;
	bool grounded;
	// public Text ScoreText;
	// public Text PowerUp;
	// public int score = 0;
	// public int health = 100;



    // void Awake()
    // {
    //     //If we don't currently have a game control...
    //     if (instance == null)
    //         //...set this one to be it...
    //         instance = this;
    //     //...otherwise...
    //     else if(instance != this)
    //         //...destroy this one because it is a duplicate.
    //         Destroy (gameObject);
    // }
	// Use this for initialization
	void Start () {
		//PowerUpDisplay("None");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)&&grounded){
				Jump();
		}
		else if(Input.GetKey(KeyCode.Space)&&!grounded&&doubleJump){
			doubleJump = false;
			Debug.Log("No Double");
		}
		GameControl.instance.PlayerScore();
		//score++;
		
		// if(speed<200f){
		//  speed+=10f;
		// }

	}
	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}
	void OnCollisionEnter2D(Collision2D collision){
		 //Debug.Log("Entered");
     	if (collision.gameObject.name == "Slope"){
         	grounded = true;
     	}

 	}
 
 
 	void OnCollisionExit2D(Collision2D collision) {
		 //Debug.Log("Exited");
     	if (collision.gameObject.name == "Slope"){
         	grounded = false;
     	}

 	}
	 void OnTriggerEnter2D(Collider2D other){
		 	if (other.gameObject.name == "PowerUp"){
         	doubleJump = true;
			other.gameObject.SetActive(false);
			Debug.Log("PowerUp");
			// PowerUpDisplay("Double Jump");
     	}
	 }

}
