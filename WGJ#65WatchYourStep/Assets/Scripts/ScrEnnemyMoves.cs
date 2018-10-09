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

    // Use this for initialization
    void Start () {
        scrGM = GameObject.Find("GameManager").GetComponent<ScrGameManager>();

        startPos = gameObject.transform.position;
        pathNumber = 1;
        goalPos = path[pathNumber];
        isGoing = true;

        moveCurrent = moveMax;
    }

    // Update is called once per frame
    void Update()
    {
        bool isPlayerTurn = scrGM.GetIsPlayerTurn();

        if (isPlayerTurn == false)
        {
            float step = moveSpeed * Time.deltaTime;

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, goalPos, step);

            if (gameObject.transform.position == goalPos && isGoing == true && pathNumber<path.Length)
            {
                pathNumber++;
                goalPos = path[pathNumber];
                moveCurrent--;

                if (pathNumber == path.Length)
                {
                    isGoing = false;
                }

            }else if (gameObject.transform.position == goalPos && isGoing == false && pathNumber > 0)
            {
                pathNumber--;
                goalPos = path[pathNumber];
                moveCurrent--;

                if (pathNumber == 0)
                {
                    isGoing = true;
                }

            }

            if (moveCurrent == 0 && gameObject.transform.position == goalPos)
            {
                scrGM.SetIsPlayerTurn(true);
                moveCurrent = moveMax;
            }

        }

    }
}
