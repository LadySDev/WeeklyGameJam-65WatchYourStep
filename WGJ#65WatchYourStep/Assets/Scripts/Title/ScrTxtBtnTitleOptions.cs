using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitle/TxtBtnOptions")]
public class ScrTxtBtnTitleOptions : MonoBehaviour {

    private string word = "Options";

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }
}
