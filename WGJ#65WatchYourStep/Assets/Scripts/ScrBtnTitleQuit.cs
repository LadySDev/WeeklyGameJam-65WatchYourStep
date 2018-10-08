using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrBtnTitleQuit : MonoBehaviour {

    private Button btnQuit;

    // Use this for initialization
    void Start () {
        btnQuit = gameObject.GetComponent<Button>();
        btnQuit.onClick.AddListener(Quit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Quit()
    {
        Application.Quit();
    }

}
