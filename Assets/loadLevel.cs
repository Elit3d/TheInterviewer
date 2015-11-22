using UnityEngine;
using System.Collections;

public class loadLevel : MonoBehaviour {

	public void LoadNext()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
