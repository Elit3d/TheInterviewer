using UnityEngine;
using System.Collections;

public class Begin_Mission : MonoBehaviour {

    private game_controller g_controller;
    int total_points;

	// Use this for initialization
	void Start () {
        g_controller = GetComponent<game_controller>();
        total_points = 0;
	}

    public void Start_The_Mission()
    {
       for (int i = 0; i < g_controller.associates.Count; i++)
       {
           total_points += g_controller.associates[i].level + g_controller.associates[i].morale;
       }

       Check_Total_Points();
    }

    void Check_Total_Points()
    {
        Debug.Log(total_points);
        if (total_points >= 0)
        {
            Debug.Log("worked");
        }
    }
}
