using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
	public static GameControl instance;
	public float scrollSpeed = -5f;
	//public Text ScoreText;
	public Text CoinsText;
	public Text ArrowText;
	public Text PowerUp;
	//public int score = 0;
	public int coins = 0;
	public int arrows = 5;
	// public int health = 100;
	public GameObject doubleJumpPower;

	public Player player;
	
    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if(instance != this)
            //...destroy this one because it is a duplicate.
            Destroy (gameObject);
    }

	// Use this for initialization
	void Start () {
		SpawnPowerUp();
		scrollSpeed = player.speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PowerUpDisplay(string power){
		PowerUp.text = "Power Up: "+power+"!".ToString();

	}
	// public void PlayerScore(){
    //     score++;
    //     ScoreText.text = "Score: " + score.ToString();
	// 	//Debug.Log(score);
    // }
	public void PlayerCoins(int value){
        coins += value;
        CoinsText.text = "Coins: " + coins.ToString();
	}
	public void PlayerArrows(int value, Arrow.ArrowType type, int arrowUI){
		switch(type){
			case Arrow.ArrowType.Normal:
				player.numArrows[0]+=value;
				break;
			case Arrow.ArrowType.Ice:
				player.numArrows[1]+=value;
				break;
			case Arrow.ArrowType.Fire:
				player.numArrows[2]+=value;
				break; 
		}
		//enum won't cast to int for index
		// player.numArrows[type] += value;
        // ArrowText.text = type.ToString() + " Arrows: " + player.numArrows[arrowUI].ToString();
		ArrowUI(arrowUI);
	}
	public void SpawnPowerUp(){
		//Instantiate(doubleJumpPower,new Vector3(10,-1,-5));

	}

	public void ArrowUI(int arrowUI){
		string type = "Fire ";
		switch(arrowUI){
			case 0:
				type = "";
				break;
			case 1: 
				type = "Ice ";
				break;
			default:
				break;
		}
		ArrowText.text = type + "Arrows: " + player.numArrows[arrowUI].ToString();
		player.selectedArrow = arrowUI;

	}

}
