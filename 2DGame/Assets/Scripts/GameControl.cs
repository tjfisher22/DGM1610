using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
	public static GameControl instance;
	public float scrollSpeed = -5f;
	public Text ScoreText;
	public Text PowerUp;
	public int score = 0;
	public int health = 100;
	
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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PowerUpDisplay(string power){
		PowerUp.text = "Power Up: "+power+"!".ToString();

	}
	public void PlayerScore(){
        score++;
        ScoreText.text = "Score: " + score.ToString();
		//Debug.Log(score);
    }

}
