using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Associate : MonoBehaviour {
    public Update_Current_Associate current_associate;

    public string name;
    public string skill;
    public int level;
    public int morale;

    public Image face;
    public List<Image> reaction_faces;

    public int current_question;
    public int current_dialogue;

    public List<string> question_dialogue;

    public List<string> first_dialogue;
    public List<string> second_dialogue;
    public List<string> third_dialogue;

    public List<int> first_dialogue_scores;
    public List<int> second_dialogue_scores;
    public List<int> third_dialogue_scores;

    public List<Button> buttons;

    private void Start()
    {
        current_question = 0;
        current_dialogue = 0;

        buttons.Add(transform.GetChild(0).GetComponent<Button>());
        buttons.Add(transform.GetChild(1).GetComponent<Button>());
        buttons.Add(transform.GetChild(2).GetComponent<Button>());
        buttons.Add(transform.GetChild(3).GetComponent<Button>());
        Update_Buttons(current_dialogue);
    }

    void Update()
    {
        current_question = current_dialogue - 1;
        
    }

    public void Next_Dialogue_Set( int i)
    {
        if (current_dialogue == 1)
        {
            morale += first_dialogue_scores[i];
        }
        if(current_dialogue == 2)
        {
            morale += second_dialogue_scores[i];
        }
        if(current_dialogue == 3)
        {
            morale += third_dialogue_scores[i];
        }
        face.sprite = reaction_faces[i].sprite;
        Update_Buttons(current_dialogue);
        current_associate.Update_Associate();
    }

    public void Update_Buttons(int dialogue_selection)
    {
        if(dialogue_selection == 0)
        {
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].transform.GetChild(0).GetComponent<Text>().text = first_dialogue[i].Replace("NEWLINE", "\n");
            }
        }
        if(dialogue_selection == 1)
        {
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].transform.GetChild(0).GetComponent<Text>().text = second_dialogue[i].Replace("NEWLINE", "\n");
            }
        }
        if(dialogue_selection == 2)
        {
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].transform.GetChild(0).GetComponent<Text>().text = third_dialogue[i].Replace("NEWLINE", "\n");
            }
        }
        if(current_dialogue > 2)
        {
            for(int i = 0; i < buttons.Count; i++)
            {
                buttons[i].interactable = false;
            }
        }
        current_dialogue++;
    }

    public string get_question(int i)
    {

        return question_dialogue[i];
    }
}
