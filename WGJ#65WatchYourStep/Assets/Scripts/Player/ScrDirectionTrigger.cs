using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrDirectionTrigger : MonoBehaviour {

    private bool isCollideObstacle;
    public void SetIsCollideObstacle(bool isCollide) { isCollideObstacle = isCollide; }
    public bool GetIsCollideObstacle() { return isCollideObstacle; }

    // Use this for initialization
    void Start () {
        isCollideObstacle = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 9)
        {            
            isCollideObstacle = true;
        }       
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 9)
        {
            isCollideObstacle = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        isCollideObstacle = false;
    }

}
