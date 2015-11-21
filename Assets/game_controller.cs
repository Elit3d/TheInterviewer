﻿using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class game_controller : MonoBehaviour {

	public update_stats[] associates_stats; //do not change this name, it will reset the array

	public Associate associate_one;
	public Associate associate_two;
	public Associate associate_three;
	public Associate associate_four;

    private  Associate curr_associate;

	public Update_Current_Associate current_associate;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this); //do not destroy when changing scene
		current_associate.Update_Text("This is a test\nOf the new line."); //@TEST tests changing current_associate text, this works
		associate_one.gameObject.SetActive(true);
		associate_one.Update_Buttons(0);
        current_associate.associate = associate_one;
        current_associate.Update_Image();
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
                associates_stats[i].current_image = current_associate.current_associate_image;
				associates_stats[i].name_text.text = "Name: " + "current_associate.associate.name";
				associates_stats[i].skill_text.text = "Skill: " + "current_associate.associate.skill";
                associates_stats[i].level_text.text = "Level: ";
                associates_stats[i].morale_text.text = "Morale: ";
				break;
			}
		}
	}

    void Next_Associate()
    {
        for (int i = 0; i < associates_stats.Length; i++)
        {
            if (associates_stats[i].Get_Slot_Taken() == false)
            {
                associates_stats[i].current_image.sprite = current_associate.current_associate_image.sprite;
                associates_stats[i].name_text.text = "Name: " + "current_associate.associate.name";
                associates_stats[i].skill_text.text = "Skill: " + "current_associate.associate.skill";
                associates_stats[i].level_text.text = "Level: " + "current_associate.associate.level";
                associates_stats[i].morale_text.text = "Morale: " + "current_associate.associate.morale";
                associates_stats[i].Set_Slot_Taken(true);
                break;
            }
        }
    }

    public void Hire_BTN()
    {
        Next_Associate();
    }
}
