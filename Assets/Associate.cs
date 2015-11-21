using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Associate : MonoBehaviour {
    public string name;
    public string skill;
    public int level;
    public int morale;


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
    }
}
