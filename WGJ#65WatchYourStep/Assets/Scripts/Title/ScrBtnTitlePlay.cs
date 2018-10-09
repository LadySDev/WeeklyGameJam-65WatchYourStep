using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitle/BtnPlay")]
public class ScrBtnTitlePlay : MonoBehaviour {

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        Button btnPlay = gameObject.GetComponent<Button>();
        btnPlay.onClick.AddListener(Play);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Play()
    {
        scrGM.Level1();
    }

}
