using UnityEngine;
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

	public Update_Current_Associate current_associate;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this); //do not destroy when changing scene
		current_associate.Update_Text("This is a test\nOf the new line."); //@TEST tests changing current_associate text, this works
		associate_one.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
