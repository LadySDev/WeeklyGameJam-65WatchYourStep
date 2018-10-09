using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/TxtValid")]
public class ScrTxtBtnTitleOptionsValid : MonoBehaviour {

    private string word = "Valid";

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }
}
