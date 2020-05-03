using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer characterSprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        characterSprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()

    {

        if (Input.GetKey(KeyCode.A))
        {
            characterSprite.flipX = true;
            this.transform.position = new Vector2(this.transform.position.x - 0.05f, this.transform.position.y);
            //rb.AddForce(Vector2.left * 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddForce(Vector2.right * Time.deltaTime);
            characterSprite.flipX = false;
            this.transform.position = new Vector2(this.transform.position.x + 0.05f, this.transform.position.y);
            
            //rb.AddForce(Vector2.right * 2);
        }
    }
}
