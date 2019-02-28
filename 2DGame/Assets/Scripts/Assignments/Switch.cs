using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Switch : MonoBehaviour {

	public string suspect;
	public string weapon;
	public string room;
	

	// Use this for initialization
	void Start () {
		MurderMystery(suspect, weapon);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void MurderMystery(string person, string tool){
		switch(person){
			case "Mr Green": //when tool == "Gun": //when doesn't work in switch statements in C#6 which is what I think Unity is using.
				print("Work");
				break;
			//case "Mr Green":
				print("Didn't");
				break;
			case "Ms. Scarlet":
				print("OLO");
				break;
			case "Col. Mustard":
				print("He's the one");
				break;
			default:
				print("No Suspect?");
				break;
		}
		// switch(weapon){
		// 	case "Knife":
		// 		print("Check the gun");
		// 	case "Gun":
		// 		print("Check the rope");
		// 	case "Rope":
		// 		print("Dis one");
		// 		break;
		// 	default:
		// 		print("No weapon?");
		// 		break;
		// }


	}
}
