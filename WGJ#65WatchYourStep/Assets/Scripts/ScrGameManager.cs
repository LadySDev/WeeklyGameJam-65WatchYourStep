using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGameManager : MonoBehaviour {

    private GameObject canva;

    [SerializeField]
    private GameObject panelTitle;

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
        Instantiate(panelTitle, canva.transform);
    }

}
