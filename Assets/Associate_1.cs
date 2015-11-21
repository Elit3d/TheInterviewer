using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Associate_1 : Associate {

	// Use this for initialization
	void Start () {
        name = "Dave";
        skill = "Lock Picking";
        level = 1;
        morale = 0;

		first_dialogue = new List<string>() {"test", "test 2", "test 3"};
		second_dialogue = new List<string>() {"tt", "tt2", "tt3", "tt4"};
		third_dialogue = new List<string>() {"yab", "daba", "doo", "ooo"};
		fourth_dialogue = new List<string>() {"crinkle", "snork", "dribbel", "boing"};

		first_dialogue_scores = new List<int>() { 0, 1, 2, 3};
		second_dialogue_scores = new List<int>() {0, 1, 2, 3};
		third_dialogue_scores = new List<int>() {0, 1, 2, 3};
		fourth_dialogue_scores = new List<int>() {0, 1, 2, 3};

        buttons.Add(transform.GetChild(0).GetComponent<Button>());
        buttons.Add(transform.GetChild(1).GetComponent<Button>());
        buttons.Add(transform.GetChild(2).GetComponent<Button>());
        buttons.Add(transform.GetChild(3).GetComponent<Button>());
	}

    public void Update_Button(int button_number)
    {
        buttons[button_number].transform.GetChild(0).GetComponent<Text>().text = "BLAHABLAAHAHAHAHAHAH";
    }
}
