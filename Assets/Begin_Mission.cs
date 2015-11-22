using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Begin_Mission : MonoBehaviour {

	private game_controller g_controller;
	int total_points;
	int lock_pick_points;
	int thief_points;
	int spy_points;
	int scout_points;
    private Text m_text;

	// Use this for initialization
	void Start () {
		g_controller = GetComponent<game_controller>();
		total_points = 0;
	}

    void OnLevelWasLoaded()
    {
        m_text = GameObject.FindWithTag("FinalText").GetComponent<Text>();
    }

	public void Start_The_Mission()
	{
	   for (int i = 0; i < g_controller.associates.Count; i++)
	   {
		   if(g_controller.associates[i].skill == "Lockpicking")
		   {
               lock_pick_points += g_controller.associates[i].level;
		   }
		   if(g_controller.associates[i].skill == "Spy")
		   {
               spy_points += g_controller.associates[i].level;
		   }
		   if(g_controller.associates[i].skill == "Thief")
		   {
               thief_points += g_controller.associates[i].level;
		   }
		   if(g_controller.associates[i].skill == "Scout")
           {
               scout_points += g_controller.associates[i].level;
           }
		   total_points += g_controller.associates[i].morale;
           
	   }
       total_points += lock_pick_points + spy_points + thief_points + scout_points;

       Application.LoadLevel("mission_scene");
	   Check_Total_Points();
		//if points  is correct, we want it to be successful
	   
	}

	void Check_Total_Points()
	{
        print(total_points);

		if (total_points >= 10)
		{
            m_text.text = "AKDMKAKDAMDKMAD";
		}
		else
		{
            m_text.text = "AKDMKAKDAMDKMAD";
		}
	}
}
