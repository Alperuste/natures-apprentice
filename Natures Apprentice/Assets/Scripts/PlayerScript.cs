using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer characterSprite;
    private Animator animator;

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

    public bool isMoving = false;

    public bool isFirstDialogDone = false;

    public GameObject panelFirstDialog;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        characterSprite = this.GetComponent<SpriteRenderer>();
        qM = this.gameObject.GetComponent<QuestManager>();

        animator = this.GetComponent<Animator>();

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
        if (collectObject == true)
        {
            qM.openFindIt();
            qM.NextQuest();
        }
        else if (talkWithMentor == true)
        {
            qM.openDialog();
            qM.NextQuest();
        }
    }

    void Move()

    {

        if (Input.GetKey(KeyCode.A) && moveLeft == true)
        {
            characterSprite.flipX = true;
            isMoving = true;
            animator.SetBool("isMoving", true);
            Debug.Log(transform.localScale.x);

            this.transform.position = new Vector2(this.transform.position.x - 0.05f, this.transform.position.y);

        }
        else if (Input.GetKey(KeyCode.D) && moveRight == true)
        {
            characterSprite.flipX = false;
            isMoving = true;
            animator.SetBool("isMoving", true);

            this.transform.position = new Vector2(this.transform.position.x + 0.05f, this.transform.position.y);
        }
        else if(true)
        {
            isMoving = false;
            animator.SetBool("isMoving", false);

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
        }
        if (collision.gameObject.tag == "Mentor")
        {
            if (isFirstDialogDone == true)
            {
                talkWithMentor = true;
            }
            else if(isFirstDialogDone == false)
            {
                panelFirstDialog.active = true;
                print("First dialog panel active");
            }
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
        }
        if (collision.gameObject.tag == "Mentor")
        {
            talkWithMentor = false;
        }
    }
}
