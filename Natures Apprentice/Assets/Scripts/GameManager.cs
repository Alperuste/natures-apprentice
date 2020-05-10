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
    public SpriteRenderer currentQuestRenderer;
	public string questName;

	[SerializeField] public Text questText;
    public int numberOfQuests = 5;
    private int questCount = 0;

    void Start()
    {
        audioGameSource = GetComponent<AudioSource>();
        selectRandomQuest();
    }

	public void selectRandomQuest()
    {
        int randomNumber = UnityEngine.Random.Range(0, questionSprites.Count - 1);
        //Debug.Log(randomNumber + " : randomNumber");
        currentQuestRenderer = questionSprites[randomNumber];
		questName = currentQuestRenderer.name;
		Debug.Log(questName + " : questName");

		questText.text = "Collect" + " " + questName;
        questCount++;
    }

	public string getQuestName()
	{
		Debug.Log(questName + " : getQuestName");
		return questName;
	}

	private void checkToProceed()
	{
			Debug.Log(currentQuestRenderer.name + " Collided with the player");
			audioGameSource.PlayOneShot(correctLetterSound, 0.9f);
			numberOfQuests--;

			while (numberOfQuests > 0)
			{
				questionSprites.Remove(currentQuestRenderer);
				Invoke("selectRandomQuest", 2f);
			}
	}
}