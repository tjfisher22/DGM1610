using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassScript : MonoBehaviour {

    public int WaterBottle = 90;
    
	// Use this for initialization
	void Start () {
		print(WaterBottle);
        Debug.Log(WaterBottle);
        WaterBottle = 80;
	}
	
	// Update is called once per frame
	void Update () {
		print(WaterBottle);
        WaterBottle = WaterBottle - 1;
        
        
	}
}
