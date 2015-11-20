using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class game_controller : MonoBehaviour {

    List<GameObject> Dialogue; //list of text options
    

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this); //do not destroy when changing scene
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
