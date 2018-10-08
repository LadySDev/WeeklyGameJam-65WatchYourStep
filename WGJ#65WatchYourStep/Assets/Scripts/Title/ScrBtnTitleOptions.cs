using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitle/BtnOptions")]
public class ScrBtnTitleOptions : MonoBehaviour {

    private Button btnOptions;

    private ScrGameManager scrGM;

	// Use this for initialization
	void Start () {

        btnOptions = gameObject.GetComponent<Button>();
        btnOptions.onClick.AddListener(ShowOptions);

        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void ShowOptions()
    {
        scrGM.ShowOptions();
        scrGM.HideTitle();
    }

}
