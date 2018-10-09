using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrLevel1 : MonoBehaviour {

    private ScrGameManager scrGM;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        scrGM.SetIsPlayerTurn(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
