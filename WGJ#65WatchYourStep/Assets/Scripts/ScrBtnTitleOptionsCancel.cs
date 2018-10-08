using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrBtnTitleOptionsCancel : MonoBehaviour {

    private Button btnCancel;

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {
        btnCancel = gameObject.GetComponent<Button>();
        btnCancel.onClick.AddListener(ShowTitle);

        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void ShowTitle()
    {
        scrGM.ShowTitle();
        scrGM.HideOptions();
    }
}
