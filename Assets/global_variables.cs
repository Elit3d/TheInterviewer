using UnityEngine;
using System.Collections;

public class global_variables : MonoBehaviour {

	public enum GAME_STATES { NONE, HIRING, MOD_TEAM}
	public static GAME_STATES STATE;

	// Use this for initialization
	void Start () {
		global_variables.STATE = global_variables.GAME_STATES.NONE;
	}
}
