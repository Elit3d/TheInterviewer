using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Update_Current_Associate : MonoBehaviour {

    public Associate associate;
    public Image current_associate_image;
    public Text current_associate_text;


    void Start()
    {
        current_associate_image = transform.GetChild(0).GetComponent<Image>();
    }

    public void Update_Stats(string stats)
    {
        Update_Image();
        Update_Text("TEst");
    }

    public void Update_Image() //replaces current image with new image
    {
        transform.GetChild(0).GetComponent<Image>().sprite = associate.face.sprite;
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
