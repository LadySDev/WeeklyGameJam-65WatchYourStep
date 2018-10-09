using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitle/TxtBtnPlay")]
public class ScrTxtBtnTitlePlay : MonoBehaviour {

    private string word = "Play";

    // Use this for initialization
    void Start () {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();                      

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }
		
}
