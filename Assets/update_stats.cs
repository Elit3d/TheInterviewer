﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class update_stats : MonoBehaviour {

	public Image current_image;
	public Text name_text;
	public Text skill_text;
	public Text level_text;
	public Text morale_text;

	// Use this for initialization
	void Start () {
        current_image = transform.GetChild(0).GetComponent<Image>();
        name_text = transform.GetChild(1).transform.GetChild(0).GetComponent<Text>();
        skill_text = transform.GetChild(1).transform.GetChild(1).GetComponent<Text>();
        level_text = transform.GetChild(1).transform.GetChild(2).GetComponent<Text>();
        morale_text = transform.GetChild(1).transform.GetChild(3).GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Update_Name(string name)
	{

	}

	public void Update_Image(ref Image image)
	{

	}

	public void Update_Skill(string skill)
	{

	}

	public void Update_Level(int level)
	{

	}

	public void Update_Morale(string morale)
	{

	}
}
