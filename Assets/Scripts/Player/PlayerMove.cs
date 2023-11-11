using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 8;
    public float leftRightSpeed = 18;
    static public bool canMove = false;


    // Update is called once per frame
    void Update()
    {
        //Move Forward
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        if(canMove == true)
        {
            //Move Left and Right
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }
            }
        }
    }
}
