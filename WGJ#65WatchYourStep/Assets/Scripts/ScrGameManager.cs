using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGameManager : MonoBehaviour {

    private GameObject canva;

    [SerializeField]
    private GameObject panelTitle;
    private GameObject instanceTitle;

    [SerializeField]
    private GameObject panelOptions;
    private GameObject instanceOptions;

    // Use this for initialization
    void Start () {

        canva = GameObject.Find("Canvas");

        ShowTitle();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowTitle()
    {
        instanceTitle = Instantiate(panelTitle, canva.transform);
    }

    public void HideTitle()
    {
        Destroy(instanceTitle);
    }

    public void ShowOptions()
    {
        instanceOptions = Instantiate(panelOptions, canva.transform);
    }

    public void HideOptions()
    {
        Destroy(instanceOptions);
    }

}
