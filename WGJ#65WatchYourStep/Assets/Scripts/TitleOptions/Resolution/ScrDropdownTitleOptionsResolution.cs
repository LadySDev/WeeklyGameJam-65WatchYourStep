using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/PanelTitleOptions/Resolution/DropdownResolution")]
public class ScrDropdownTitleOptionsResolution : MonoBehaviour {

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {

        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        List<Resolution> resolutions = scrGM.GetResolutions();

        List<string> strResList = new List<string>();

        int iterator = 0;
        int selectedIndex = 0;

        foreach (Resolution res in resolutions)
        {
            strResList.Add(res.width + "x" + res.height);

            if (res.width == scrGM.GetCurrentResolution().width && res.height == scrGM.GetCurrentResolution().height)
            {
                selectedIndex = iterator;
            }

            iterator++;
        }

        gameObject.GetComponent<Dropdown>().AddOptions(strResList);
        gameObject.GetComponent<Dropdown>().value = selectedIndex;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
