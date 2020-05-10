using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private AudioSource audioGameSource;
    [SerializeField] public AudioClip correctLetterSound;

    [SerializeField] List<SpriteRenderer> questionSprites = new List<SpriteRenderer>();
    private SpriteRenderer randomQuestRenderer;

    [SerializeField] public Text questText;
    private int numberOfQuests = 5;
    private int questCount = 0;

    void Start()
    {
        audioGameSource = GetComponent<AudioSource>();

        selectRandomQuest();
        
    }

    public void selectRandomQuest()
    {
        int randomNumber = UnityEngine.Random.Range(0, questionSprites.Count - 1);
        Debug.Log(randomNumber + " : randomNumber");
        randomQuestRenderer = questionSprites[randomNumber];
        Debug.Log(randomQuestRenderer.name + " : randomQuestRenderer");

        questText.text = "Collect" + " " + randomQuestRenderer.name;
        questCount++;

    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(randomQuestRenderer.name + " Collided with the player");

        if (collision.gameObject.name == randomQuestRenderer.name)
        {
            Debug.Log(randomQuestRenderer.name + " Collided with the player");
            Destroy(gameObject);
            audioGameSource.PlayOneShot(correctLetterSound, 0.9f);
            numberOfQuests--;

            while(numberOfQuests > 0){
                  questionSprites.Remove(randomQuestRenderer);
                  Invoke("selectRandomQuest", 2f);
            }
        }
    }

    //  private void OnTriggerExit2D(Collider2D collision)
    // {
    //   Debug.Log(randomQuestRenderer.name + " Collided with the player");

    //     if (collision.gameObject.name == randomQuestRenderer.name)
    //     {
    //         Debug.Log(randomQuestRenderer.name + " Collided with the player");
    //         Destroy(gameObject);
    //         audioGameSource.PlayOneShot(correctLetterSound, 0.9f);
    //         questionSprites.Remove(randomQuestRenderer);
    //         Invoke("selectRandomQuest", 2f);
    //     }
    // }
}

