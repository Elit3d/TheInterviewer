using UnityEngine;
using System.Collections;

public class spawnDialogue : MonoBehaviour {
    public GameObject dialogueElement;
    public Canvas parent;
	// Use this for initialization
	void Start () {
        GameObject text_object = Instantiate(dialogueElement, transform.position, Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
