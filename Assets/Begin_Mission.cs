using UnityEngine;
using System.Collections;

public class Begin_Mission : MonoBehaviour {

	private game_controller g_controller;
	int total_points;
	int lock_pick_points;
	int thief_points;
	int spy_points;
	int scout_points;

	// Use this for initialization
	void Start () {
		g_controller = GetComponent<game_controller>();
		total_points = 0;
	}

	public void Start_The_Mission()
	{
	   for (int i = 0; i < g_controller.associates.Count; i++)
	   {
		   if(g_controller.associates[i].skill == "Lockpicking")
		   {

		   }
		   if(g_controller.associates[i].skill == "Spy")
		   {

		   }
		   if(g_controller.associates[i].skill == "")
		   {

		   }
		   if(g_controller.associates[i].skill == "")
		   total_points += g_controller.associates[i].level + g_controller.associates[i].morale;
	   }

	   Check_Total_Points();
		//if points  is correct, we want it to be successful
	   Application.LoadLevel("mission_scene");
	}

	void Check_Total_Points()
	{   
		if (total_points >= 10)
		{
			Debug.Log("worked");
		}
		else
		{
			Debug.Log("failed");
		}
	}
}
