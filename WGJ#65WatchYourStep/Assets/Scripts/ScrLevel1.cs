﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrLevel1 : MonoBehaviour {

    private ScrGameManager scrGM;

    private Vector3 startPosPlayer;
    private Vector3 startPosEnnemy1;

    [SerializeField]
    private GameObject player;
    private GameObject instancePlayer;

    [SerializeField]
    private GameObject ennemy1;
    private GameObject instanceEnnemy1;
        
    private Vector3[] pathEnnemy1;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        // Player
        startPosPlayer = new Vector3(-8, -4, 0);

        instancePlayer = Instantiate(player);
        instancePlayer.transform.position = startPosPlayer;
                
        // Ennemy
        startPosEnnemy1 = new Vector3(6, 2, 0);

        instanceEnnemy1 = Instantiate(ennemy1);
        instanceEnnemy1.transform.position = startPosEnnemy1;

        // Ennemy Path
        pathEnnemy1 = new Vector3[]
        {
            startPosEnnemy1,
            new Vector3(6, 1, 0),
            new Vector3(5, 1, 0),
            new Vector3(4, 1, 0),
            new Vector3(4, 0, 0),            
            new Vector3(3, 0, 0),
            new Vector3(2, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 0),
            new Vector3(-1, 0, 0),
            new Vector3(-2, 0, 0),
            new Vector3(-3, 0, 0),
            new Vector3(-4, 0, 0),
            new Vector3(-5, 0, 0),
        };

        instanceEnnemy1.GetComponent<ScrEnnemyMoves>().SetPath(pathEnnemy1);

        scrGM.SetIsPlayerTurn(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
