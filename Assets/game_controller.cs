using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class game_controller : MonoBehaviour {

    public GameObject dialog_option_1; //individual text options
    public GameObject dialog_option_2;
    public GameObject dialog_option_3;
    public GameObject dialog_option_4;

    private int score;

    List<GameObject> Dialogue; //list of text options
    

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this); //do not destroy when changing scene

        Dialogue = new List<GameObject>();

        //add dialogue options for list for iteration
        Dialogue.Add(dialog_option_1);
        Dialogue.Add(dialog_option_2);
        Dialogue.Add(dialog_option_3);
        Dialogue.Add(dialog_option_4);
        Read_File();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Read_File()
    {
        string line;
        System.IO.StreamReader file =
        new System.IO.StreamReader("Assets/temp_dialogue.txt");
        while ((line = file.ReadLine()) != null)
        {
            Dialogue[element_counter].transform.GetChild(0).GetComponent<Text>().text = line;
            element_counter++;
        }

        file.Close();
    }
}
