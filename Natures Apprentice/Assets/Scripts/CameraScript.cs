using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    bool moveLeft = true;
    [SerializeField]
    bool moveRight = true;

    public Transform playerTransform;
    [SerializeField]
    private Transform oldPos;

    // Start is called before the first frame update
    void Start()
    {
        oldPos = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true && moveRight == true)
        {
            FollowPlayer();
        }
        else if (moveLeft == false && moveRight == true)
        {
            if (oldPos.position.x > playerTransform.position.x)
            {

            }
            else if (oldPos.position.x <= playerTransform.position.x)
            {
                FollowPlayer();
            }
        }
        else if (moveRight == false && moveLeft == true)
        {
            if (oldPos.position.x < playerTransform.position.x)
            {

            }
            else if (oldPos.position.x >= playerTransform.position.x)
            {
                FollowPlayer();
            }
        }
    }

    void FollowPlayer()
    {
        Transform oldPos = this.transform;
        transform.position = new Vector3(playerTransform.position.x, this.transform.position.y, this.transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LeftPlaceHolder")
        {
            moveLeft = false;
        }
        else if (collision.gameObject.name == "RightPlaceHolder")
        {
            moveRight = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LeftPlaceHolder")
        {
            moveLeft = true;
        }
        else if (collision.gameObject.name == "RightPlaceHolder")
        {
            moveRight = true;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "LeftPlaceHolder")
    //    {
    //        moveLeft = false;
    //    }
    //    else if (collision.gameObject.name == "RightPlaceHolder")
    //    {
    //        moveRight = false;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "LeftPlaceHolder")
    //    {
    //        moveLeft = true;
    //    }
    //    else if (collision.gameObject.name == "RightPlaceHolder")
    //    {
    //        moveRight = true;
    //    }
    //}
}
