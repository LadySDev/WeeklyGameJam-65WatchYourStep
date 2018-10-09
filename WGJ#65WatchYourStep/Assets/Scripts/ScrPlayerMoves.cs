using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayerMoves : MonoBehaviour {

    private ScrGameManager scrGM;
    private Vector3 goalPos;
    private bool canPressButton;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private int moveMax;
    private int moveCurrent;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        goalPos = gameObject.transform.position;

        canPressButton = true;

        moveCurrent = moveMax;
    }
	
	// Update is called once per frame
	void Update () {
        bool isPlayerTurn = scrGM.GetIsPlayerTurn();

        if (isPlayerTurn == true)
        {
            float step = moveSpeed * Time.deltaTime;

            if (Input.GetKeyDown("up") && canPressButton == true)
            {
                goalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                canPressButton = false;
                moveCurrent--;
            }
            else if (Input.GetKeyDown("down") && canPressButton == true)
            {
                goalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                canPressButton = false;
                moveCurrent--;
            }
            else if (Input.GetKeyDown("left") && canPressButton == true)
            {
                goalPos = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                canPressButton = false;
                moveCurrent--;
            }
            else if (Input.GetKeyDown("right") && canPressButton == true)
            {
                goalPos = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                canPressButton = false;
                moveCurrent--;
            }

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, goalPos, step);            

            if (gameObject.transform.position == goalPos)
            {
                canPressButton = true;                
            }

            if (moveCurrent == 0 && gameObject.transform.position == goalPos)
            {
                scrGM.SetIsPlayerTurn(false);
                moveCurrent = moveMax;
            }

        }

    }
       
}
