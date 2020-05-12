using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer characterSprite;

    [SerializeField]
    bool moveLeft = true;
    [SerializeField]
    bool moveRight = true;

    [SerializeField]
    bool talkWithMentor = false;
    [SerializeField]
    bool collectObject = false;
    GameObject touchingObject;

    QuestManager qM;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        characterSprite = this.GetComponent<SpriteRenderer>();
        qM = this.gameObject.GetComponent<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Interact();
        }
    }

    void Interact()
    {
        if (talkWithMentor == true || collectObject == true)
        {
            qM.NextQuest();
        }
    }

    void Move()

    {

        if (Input.GetKey(KeyCode.A) && moveLeft == true)
        {
            characterSprite.flipX = true;
            this.transform.position = new Vector2(this.transform.position.x - 0.05f, this.transform.position.y);
            //rb.AddForce(Vector2.left * 2);
        }
        if (Input.GetKey(KeyCode.D) && moveRight == true)
        {
            //rb.AddForce(Vector2.right * Time.deltaTime);
            characterSprite.flipX = false;
            this.transform.position = new Vector2(this.transform.position.x + 0.05f, this.transform.position.y);

            //rb.AddForce(Vector2.right * 2);
        }
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


        if (collision.gameObject.tag == "Collectible")
        {
            collectObject = true;
            //touchingObject = collision.gameObject;
        }
        if (collision.gameObject.tag == "Mentor")
        {
            talkWithMentor = true;
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


        if (collision.gameObject.tag == "Collectible")
        {
            collectObject = false;
            //touchingObject = null;
        }
        if (collision.gameObject.tag == "Mentor")
        {
            talkWithMentor = false;
        }
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Collectible")
    //    {
    //        if (Input.GetKeyDown(KeyCode.F))
    //        {
    //            //Destroy(collision.gameObject);
    //            qM.NextQuest();
    //        }
    //    }
    //    if (collision.gameObject.tag == "Mentor")
    //    {
    //        if (Input.GetKeyDown(KeyCode.F))
    //        {
    //            // Make Talking
    //            qM.NextQuest();
    //        }
    //    }
    //}

}
