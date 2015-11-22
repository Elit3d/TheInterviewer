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
    public Text m_text;

	// Use this for initialization
	void Start () {
		g_controller = GetComponent<game_controller>();
		total_points = 0;
	}

    void OnLevelWasLoaded()
    {
        print("Level loaded");
        m_text = GameObject.FindWithTag("Canvas").transform.GetChild(1).GetComponent<Text>();
        Check_Total_Points();
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
		//if points  is correct, we want it to be successful
	   
	}

	void Check_Total_Points()
	{
        print(total_points);

		if (total_points >= 10)
		{
            print(total_points);
            m_text.text = "You got away with it!";
            string lockpick_text = "\nCapable lockpicking got you: " + (lock_pick_points * 2000).ToString();
            string spy_text = "\nSpying on the customers got you: " + (spy_points * 2000).ToString();
            string thief_text = "\nExperienced thieves got you: " + (thief_points * 2000).ToString();
            string scout_text = "\nScouting the building got you: " + (scout_points * 2000).ToString();
            
            int total_money = game_controller.money + (lock_pick_points * 2000) + (spy_points * 2000) + (thief_points * 2000) + (scout_points * 2000);
            string total_score = "\nTotal haul: " + (total_money).ToString();
            m_text.text += lockpick_text + spy_text + thief_text + scout_text + total_score;
            
		}
		else
		{
            m_text.text = "You failed and \n were all caught.";
		}
	}
}
