using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/FullScreen/ToggleFullScreen")]
public class ScrToggleTitleOptionsFullScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        gameObject.GetComponent<Toggle>().isOn = scrGM.GetFullScreen();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
