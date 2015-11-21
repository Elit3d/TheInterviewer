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

    public void Update_Associate()
    {
        Update_Image();
        Update_Text();
    }

    public void Update_Image() //replaces current image with new image
    {
        transform.GetChild(0).GetComponent<Image>().sprite = associate.face.sprite;
    }

    public void Update_Text() //replaces current text with new text
    {
        if (associate.current_question < associate.question_dialogue.Count - 1)
        {
            current_associate_text.text = associate.question_dialogue[associate.current_dialogue - 1];
        }

    }

    public Associate Get_Associate()
    {
        return associate;
    }
}
