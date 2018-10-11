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
    
    [SerializeField]
    private Sprite arrow;
    private GameObject arrowUp;
    private GameObject arrowDown;
    private GameObject arrowLeft;
    private GameObject arrowRight;

    private bool isMoveUpAllowed;
    private bool isMoveDownAllowed;
    private bool isMoveLeftAllowed;
    private bool isMoveRightAllowed;

    private bool isItFirstAppearance;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        goalPos = gameObject.transform.position;

        canPressButton = true;

        moveCurrent = moveMax;

        foreach (Transform child in gameObject.GetComponent<Transform>())
        {
            if (child.gameObject.name == "ArrowUp")
            {
                arrowUp = child.gameObject;
            }

            if (child.gameObject.name == "ArrowDown")
            {
                arrowDown = child.gameObject;
            }
            if (child.gameObject.name == "ArrowLeft")
            {
                arrowLeft = child.gameObject;
            }

            if (child.gameObject.name == "ArrowRight")
            {
                arrowRight = child.gameObject;
            }
        }

        ClearArrows();
        isItFirstAppearance = true;
    }
	
	// Update is called once per frame
	void Update () {       

        bool isPlayerTurn = scrGM.GetIsPlayerTurn();
        
        if (isPlayerTurn == true)
        {
            float step = moveSpeed * Time.deltaTime;

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, goalPos, step);

            if (moveCurrent > 0)
            {

                if (canPressButton == true)
                {

                    if (isItFirstAppearance == true)
                    {
                        CheckMoveDirectionAllowed();
                        isItFirstAppearance = false;
                    }

                    if (Input.GetKeyDown("up") && isMoveUpAllowed == true)
                    {
                        goalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                        canPressButton = false;
                        moveCurrent--;
                        ClearArrows();
                    }
                    else if (Input.GetKeyDown("down") && isMoveDownAllowed == true)
                    {
                        goalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                        canPressButton = false;
                        moveCurrent--;
                        ClearArrows();
                    }
                    else if (Input.GetKeyDown("left") && isMoveLeftAllowed == true)
                    {
                        goalPos = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                        canPressButton = false;
                        moveCurrent--;
                        ClearArrows();
                    }
                    else if (Input.GetKeyDown("right") && isMoveRightAllowed == true)
                    {
                        goalPos = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                        canPressButton = false;
                        moveCurrent--;
                        ClearArrows();
                    }

                }
                
                if (gameObject.transform.position == goalPos)
                {
                    CheckMoveDirectionAllowed();
                    canPressButton = true;
                }

            }            
            else if (moveCurrent == 0 && gameObject.transform.position == goalPos)
            {
                scrGM.SetIsPlayerTurn(false);
                moveCurrent = moveMax;
            }

        }
      
    }
       
    private void CheckMoveDirectionAllowed()
    {        
        if (arrowUp.GetComponent<ScrDirectionTrigger>().GetIsCollideObstacle() == false)
        {
            isMoveUpAllowed = true;            
        }
        else
        {
            isMoveUpAllowed = false;
        }

        if (arrowDown.GetComponent<ScrDirectionTrigger>().GetIsCollideObstacle() == false)
        {
            isMoveDownAllowed = true;
        }
        else
        {
            isMoveDownAllowed = false;
        }

        if (arrowLeft.GetComponent<ScrDirectionTrigger>().GetIsCollideObstacle() == false)
        {
            isMoveLeftAllowed = true;
        }
        else
        {
            isMoveLeftAllowed = false;
        }

        if (arrowRight.GetComponent<ScrDirectionTrigger>().GetIsCollideObstacle() == false)
        {
            isMoveRightAllowed = true;
        }
        else
        {
            isMoveRightAllowed = false;
        }

        ShowArrowsAllowed();
    }

    private void ShowArrowsAllowed()
    {
        if (isMoveUpAllowed == true) { arrowUp.GetComponent<SpriteRenderer>().sprite = arrow; }

        if (isMoveDownAllowed == true) { arrowDown.GetComponent<SpriteRenderer>().sprite = arrow; }

        if (isMoveLeftAllowed == true) { arrowLeft.GetComponent<SpriteRenderer>().sprite = arrow; }

        if (isMoveRightAllowed == true) { arrowRight.GetComponent<SpriteRenderer>().sprite = arrow; }
    }

    private void ClearArrows()
    {
        arrowUp.GetComponent<SpriteRenderer>().sprite = null;
        arrowDown.GetComponent<SpriteRenderer>().sprite = null;
        arrowLeft.GetComponent<SpriteRenderer>().sprite = null;
        arrowRight.GetComponent<SpriteRenderer>().sprite = null;
    }

}
