using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Update_Current_Associate : MonoBehaviour {

    public Associate associate;
    public Image current_associate_image;
    public Text current_associate_text;

    public void Update_Image(ref Image new_image) //replaces current image with new image
    {
        current_associate_image = new_image;
    }

    public void Update_Text(string new_associate_text) //replaces current text with new text
    {
        current_associate_text.text = new_associate_text;
    }

    public Associate Get_Associate()
    {
        return associate;
    }
}
