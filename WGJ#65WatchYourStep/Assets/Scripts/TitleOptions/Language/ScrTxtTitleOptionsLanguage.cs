﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/Language/TxtLanguage")]
public class ScrTxtTitleOptionsLanguage : MonoBehaviour {

    private ScrLanguage currentScrLanguage;

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        currentScrLanguage = scrGM.GetCurrentScrLanguage();
        gameObject.GetComponent<Text>().text = currentScrLanguage.TranslationWord("Language");
    }
       
}
