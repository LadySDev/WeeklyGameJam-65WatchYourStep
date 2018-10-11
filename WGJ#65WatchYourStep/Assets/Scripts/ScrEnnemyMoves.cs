using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEnnemyMoves : MonoBehaviour {

    private ScrGameManager scrGM;

    private Vector3 startPos;
    private Vector3 goalPos;

    private Vector3[] path;
    public void SetPath(Vector3[] pathEnnemy) { path = pathEnnemy; }        
    private int pathNumber;
    private bool isGoing;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private int moveMax;
    private int moveCurrent;

    [SerializeField]
    private Sprite light;
    private Vector3 oldPosition;
    private Vector3 newPosition;    
    private GameObject lightUp;
    private GameObject lightDown;
    private GameObject lightLeft;
    private GameObject lightRight;

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        startPos = gameObject.transform.position;
        pathNumber = 1;
        goalPos = path[pathNumber];
        isGoing = true;

        moveCurrent = moveMax;

        oldPosition = startPos;

        foreach (Transform child in gameObject.GetComponent<Transform>())
        {
            if (child.gameObject.name == "LightUp")
            {
                lightUp = child.gameObject;
            }

            if (child.gameObject.name == "LightDown")
            {
                lightDown = child.gameObject;
            }
            if (child.gameObject.name == "LightLeft")
            {
                lightLeft = child.gameObject;
            }

            if (child.gameObject.name == "LightRight")
            {
                lightRight = child.gameObject;
            }            
        }
    }

    // Update is called once per frame
    void Update()
    {

        ClearAllLights();
        LightDirection();

        bool isPlayerTurn = scrGM.GetIsPlayerTurn();

        if (isPlayerTurn == false)
        {
            float step = moveSpeed * Time.deltaTime;

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, goalPos, step);
            
            if (moveCurrent == 0 && gameObject.transform.position == goalPos)
            {
                scrGM.SetIsPlayerTurn(true);
                moveCurrent = moveMax;                                
            }

            if (gameObject.transform.position == goalPos && isGoing == true && pathNumber<path.Length-1)
            {
                pathNumber++;
                goalPos = path[pathNumber];
                moveCurrent--;

                if (pathNumber == path.Length-1)
                {
                    isGoing = false;
                }

            }
            else if (gameObject.transform.position == goalPos && isGoing == false && pathNumber > 0)
            {
                pathNumber--;
                goalPos = path[pathNumber];
                moveCurrent--;

                if (pathNumber == 0)
                {
                    isGoing = true;
                }
                
            }
                        
        }

    }

    private void LightDirection()
    {
        newPosition = gameObject.transform.position;       

        if (newPosition.x - oldPosition.x == 0 && newPosition.y - oldPosition.y > 0)
        {
            lightUp.GetComponent<SpriteRenderer>().sprite = light;            
        }
        else if (newPosition.x - oldPosition.x == 0 && newPosition.y - oldPosition.y < 0)
        {
            lightDown.GetComponent<SpriteRenderer>().sprite = light;
        }
        else if (newPosition.x - oldPosition.x < 0 && newPosition.y - oldPosition.y == 0)
        {
            lightLeft.GetComponent<SpriteRenderer>().sprite = light;
        }
        else if (newPosition.x - oldPosition.x > 0 && newPosition.y - oldPosition.y == 0)
        {
            lightRight.GetComponent<SpriteRenderer>().sprite = light;
        }

        oldPosition = gameObject.transform.position;
    }

    private void ClearAllLights()
    {
        lightUp.GetComponent<SpriteRenderer>().sprite = null;
        lightDown.GetComponent<SpriteRenderer>().sprite = null;
        lightLeft.GetComponent<SpriteRenderer>().sprite = null;
        lightRight.GetComponent<SpriteRenderer>().sprite = null;
    }

}
