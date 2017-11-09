using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour {
	int number=50;
	// Use this for initialization
	void Start () {
		
		print("Welcome to Number Wizard");
		print("Pick a random number from 1- 1000");
		
		print("Is the number higher, lower or equal to "+ number+"?");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up"))
		{
			print("up arrow pressed");
			number = number+1;
			print("The current number is"+number);
		}
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			print("down arrow pressed");
			number= number-1;
			print("The current number is"+number);
		}
	}
}
