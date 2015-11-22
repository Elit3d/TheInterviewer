using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class update_stats : MonoBehaviour {

	public Image current_image;
	public Text name_text;
	public Text skill_text;
	public Text level_text;
	public Text morale_text;

    public Associate linked_associate;

    private bool slot_taken; // is the friend tab taken if not add character.

	// Use this for initialization
	void Start () {
        current_image = transform.GetChild(0).GetComponent<Image>();
        name_text = transform.GetChild(1).transform.GetChild(0).GetComponent<Text>();
        skill_text = transform.GetChild(1).transform.GetChild(1).GetComponent<Text>();
        level_text = transform.GetChild(1).transform.GetChild(2).GetComponent<Text>();
        morale_text = transform.GetChild(1).transform.GetChild(3).GetComponent<Text>();

        slot_taken = false;
	}

	public void Update_Level()
	{
        level_text.text = "Level: " + linked_associate.level.ToString();
	}

    public bool Get_Slot_Taken()
    {
        return slot_taken;
    }

    public void Set_Slot_Taken(bool slotTaken)
    {
        slot_taken = slotTaken;
    }

    public void increment_morale()
    {
        if (game_controller.money >= 5000)
        {
            print(linked_associate.morale);
            linked_associate.morale++;
            morale_text.text = "Morale: " + linked_associate.morale.ToString();
            game_controller.money -= 5000;
        }
    }

    public void decrement_morale()
    {
        if (linked_associate.morale > 0 && linked_associate.morale < 20)
        {
            linked_associate.morale--;
            morale_text.text = "Morale: " + linked_associate.morale.ToString();
            game_controller.money += 5000;
        }
    }
}
