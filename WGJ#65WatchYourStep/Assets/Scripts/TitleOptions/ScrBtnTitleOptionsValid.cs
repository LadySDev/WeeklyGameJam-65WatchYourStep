using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/BtnValid")]
public class ScrBtnTitleOptionsValid : MonoBehaviour {

    private Button btnValid;

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {
        btnValid = gameObject.GetComponent<Button>();
        btnValid.onClick.AddListener(Valid);

        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Valid()
    {
        // String Language
        string strLang = GameObject.Find("DropdownTitleOptionsLanguage").GetComponent<Dropdown>().captionText.text;
        foreach (string language in scrGM.GetLanguages())
        {
            if (strLang == language)
            {
                scrGM.SetCurrentLanguage(language);
            }
        }

        // String Resolution
        string strRes = GameObject.Find("DropdownTitleOptionsResolution").GetComponent<Dropdown>().captionText.text;

        string[] str = strRes.Split('x');
        int width = int.Parse(str[0]);           
        int height = int.Parse(str[1]);

        foreach (Resolution res in scrGM.GetResolutions())
        {
            if (res.width == width && res.height == height)
            {
                scrGM.SetCurrentResolution(res);
            }
        }

        // Change Bool FullScreen
        scrGM.SetFullScreen(GameObject.Find("ToggleTitleOptionFullScreen").GetComponent<Toggle>().isOn);

        scrGM.ShowTitle();
        scrGM.HideOptions();
    }

}
