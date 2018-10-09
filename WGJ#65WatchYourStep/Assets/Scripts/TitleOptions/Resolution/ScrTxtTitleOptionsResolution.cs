using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/Resolution/TxtResolution")]
public class ScrTxtTitleOptionsResolution : MonoBehaviour {

    private string word = "Resolution";

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }
}
