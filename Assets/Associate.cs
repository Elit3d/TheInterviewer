using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Associate : MonoBehaviour {
    public string name;
    public string skill;
    public int level;
    public int morale;

    public Image face;

    public List<string> question_dialogue;

    public List<string> first_dialogue;
    public List<string> second_dialogue;
    public List<string> third_dialogue;
    public List<string> fourth_dialogue;


    public List<int> first_dialogue_scores;
    public List<int> second_dialogue_scores;
    public List<int> third_dialogue_scores;
    public List<int> fourth_dialogue_scores;

    public List<Button> buttons;

    private void Start()
    {
        buttons.Add(transform.GetChild(0).GetComponent<Button>());
        buttons.Add(transform.GetChild(1).GetComponent<Button>());
        buttons.Add(transform.GetChild(2).GetComponent<Button>());
        buttons.Add(transform.GetChild(3).GetComponent<Button>());
        Update_Buttons(0);
    }

    public void Update_Buttons(int dialogue_selection)
    {
        if(dialogue_selection == 0)
        {
            print(buttons.Count);
            for(int i = 0; i < buttons.Count; i++)
            {
                print("Working");
                buttons[i].transform.GetChild(0).GetComponent<Text>().text = first_dialogue[i];
            }
        }
    }
}
