using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour{
    public Text myText;


    // Use this for initialization
    void Start () {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void StartGame()
    {
        System.Random rnd = new System.Random();
        int value1 = rnd.Next(1, 10);
        int value2 = rnd.Next(1, 10);
        int total = value1 * value2;

        myText.text = "What is " +value1+"*"+value2+"=";

    }
}
