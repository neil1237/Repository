using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	public Text myText;

    enum States { cell, sheets_0,mirror,lock_0,cell_mirror, sheets_1,lock_1, freedom };

    States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {

        if (myState == States.cell)
        {
            Cell();
        }
        else if (myState == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myState == States.mirror)
        {
            Mirror();
        }
        else if (myState == States.lock_0)
        {
            Lock_0();
        }
        else if (myState == States.cell_mirror)
        {
            Cell_Mirror();
        }
        else if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myState == States.lock_1)
        {
            Lock_1();
        }
        else if (myState == States.freedom)
        {
            Freedom();
        }
        
    }

    void Cell()
    {
        myText.text = "You are in a prison cell , and you want to escape" +
            "\nThere are some dirty sheets on the bed, a mirror on the wall" +
            "\nand the door is locked from the outside\n\n" +
            "Press S to view the sheets, M to view the Mirror and L to " +
            "view the lock.";

        if (Input.GetKeyDown(KeyCode.S)) { myState= States.sheets_0; }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void Sheets_0()
    {
        myText.text = "These are very dirty sheets." +
            "/n/n Press on R to return to the cell";


        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
        void Mirror()
        {
            myText.text = "Press R to return to cell";
            if (Input.GetKeyDown(KeyCode.T))
            {
                myState = States.cell_mirror;
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.cell;
            }
        }

    void Lock_0()
    {
        myText.text = "This is one ";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void Cell_Mirror()
    {
        myText.text = "You are still in your cell. Press S to view the sheets , L to view the lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }
    void Sheets_1()
    {
        myText.text = "The text here is being skipped by a line\n\n" +
            "Press R to return to to cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void Lock_1()
    {
        myText.text = "The text here is being skipped by a line\n\n" +
            "Press R to return to the cell press O to open the door";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void Freedom()
    {
        myText.text = "You are finally Free \n\n" +
            "Press P to Play Again or Q to Quit ";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    }  
        
    
