using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class game_controller : MonoBehaviour {

	public update_stats[] associates_stats; //do not change this name, it will reset the array

	public List<Associate> associates;

	int curr_associate;

	public Update_Current_Associate current_associate;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this); //do not destroy when changing scene
		curr_associate = 0;
		Init_Associate(curr_associate);
		
	}
	
	void Init_Associate(int i)
	{
		associates[curr_associate].gameObject.SetActive(true);
		associates[curr_associate].Update_Buttons(0);
		current_associate.associate = associates[curr_associate];
		current_associate.Update_Associate();
	}

	// Update is called once per frame
	void Update () {
	}

	void Add_To_Slot()
	{
		for (int i = 0; i < associates_stats.Length; i++)
		{
			if (associates_stats[i].Get_Slot_Taken() == false)
			{
				associates_stats[i].current_image.sprite = current_associate.current_associate_image.sprite;
				associates_stats[i].name_text.text = "Name: " + current_associate.associate.name;
				associates_stats[i].skill_text.text = "Skill: " + current_associate.associate.skill;
				associates_stats[i].level_text.text = "Level: " + current_associate.associate.level.ToString();
				associates_stats[i].morale_text.text = "Morale: " + current_associate.associate.morale.ToString();
				associates_stats[i].Set_Slot_Taken(true);
				break;
			}
		}
	}

	void Next_Associate()
	{
		curr_associate++;
		Init_Associate(curr_associate);
	}


	public void Hire_BTN()
	{
        //add to our team
		Add_To_Slot();
		Next_Associate();
	}

    public void Dismiss_BTN()
    {
        //dismiss current one
        Next_Associate();
    }
}
