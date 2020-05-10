using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : GameManager
{

    public bool didCollide = false;
    public GameManager gameManager;

	// Start is called before the first frame update
	void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        Debug.Log("questName from ColliderScript" + " " + gameManager.getQuestName());
        Debug.Log("number of quests" + " " + gameManager.numberOfQuests);

        didCollide = true;
        Debug.Log("didCollide with: " + collision.gameObject.name);
    }
}
