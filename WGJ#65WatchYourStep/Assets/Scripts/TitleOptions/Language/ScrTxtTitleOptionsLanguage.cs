using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/Language/TxtLanguage")]
public class ScrTxtTitleOptionsLanguage : MonoBehaviour {

    private string word = "Language";

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }

}
