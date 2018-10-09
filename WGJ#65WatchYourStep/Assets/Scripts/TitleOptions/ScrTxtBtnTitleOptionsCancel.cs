using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/TxtCancel")]
public class ScrTxtBtnTitleOptionsCancel : MonoBehaviour {

    private string word = "Cancel";

    // Use this for initialization
    void Start()
    {
        ScrGameManager scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.TranslateWord(word, gameObject.GetComponent<Text>());

    }
}
