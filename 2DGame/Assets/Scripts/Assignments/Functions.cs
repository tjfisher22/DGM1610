using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
	
	public string currentWeather;

	void Start(){
		
		Weather(currentWeather);
	}



	void Weather(string weatherState){

		

		if(weatherState=="sunny"){
			print("The sun is a deadly laser");
		}
		else if (weatherState=="raining")
		{
			print("Not anymore, there's a blanket");
		}
		else if (weatherState=="windy")
		{
			print("Please respect us");
		}
		else if (weatherState=="snowing")
		{
			print("Even crazier space dust");
		}
		else if (weatherState=="ashy")
		{
			print("Mount St. Helens is about to blow up");
		}
		else{

			print("The current weather is "+weatherState);
		}



	}

}
