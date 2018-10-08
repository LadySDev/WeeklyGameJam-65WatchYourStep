using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/Language/DropdownLanguages")]
public class ScrDropdownTitleOptionsLanguage : MonoBehaviour {

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        List<string> languages = scrGM.GetLanguages();

        gameObject.GetComponent<Dropdown>().AddOptions(languages);

        for(int i=0;i<languages.Count;i++)
        {
            if (languages[i] == scrGM.GetCurrentLanguage())
            {
                gameObject.GetComponent<Dropdown>().value = i;
            }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
