using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitle/TxtBtnPlay")]
public class ScrTxtBtnTitlePlay : MonoBehaviour {

    private ScrLanguage currentScrLanguage;

    // Use this for initialization
    void Start () {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        currentScrLanguage = scrGM.GetCurrentScrLanguage();
        gameObject.GetComponent<Text>().text = currentScrLanguage.TranslationWord("Play");
    }
		
}
