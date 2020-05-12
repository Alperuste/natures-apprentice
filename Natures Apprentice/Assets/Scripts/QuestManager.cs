using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [SerializeField] int activeQuest = 0;
    [HideInInspector]
    public string questName;
    [HideInInspector]
    public string questDesc;
    [SerializeField]
    Text txtQuestText;

    [SerializeField]
    GameObject mentor;

    public GameObject questObject1;
    public GameObject questObject2;
    public GameObject questObject3;
    public GameObject questObject4;
    public GameObject questObject5;
    public GameObject questObject6;

    // Start is called before the first frame update
    void Start()
    {
        QuestActivate();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NextQuest()
    {
        activeQuest++;
        QuestActivate();
    }

    public void ActivateMentor()
    {
        // Activate talk with mentor
        mentor.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void DeactivateMentor()
    {
        mentor.GetComponent<BoxCollider2D>().enabled = false;
    }

    void QuestActivate()
    {
        if (activeQuest == 0)
        {
            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();
        }
        else if (activeQuest == 1)
        {
            DeactivateMentor();
            questName = "quest name 1";
            questDesc = "quest desc 1";
            questObject1.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (activeQuest == 2)
        {
            questObject1.GetComponent<BoxCollider2D>().enabled = false;
            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        else if (activeQuest == 3)
        {
            DeactivateMentor();
            questName = "quest name 3";
            questDesc = "quest desc 3";
            questObject2.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (activeQuest == 4)
        {
            questObject2.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        else if (activeQuest == 5)
        {
            DeactivateMentor();

            questName = "quest name 5";
            questDesc = "quest desc 5";
            questObject3.GetComponent<BoxCollider2D>().enabled = true;

        }
        else if (activeQuest == 6)
        {
            questObject3.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        else if (activeQuest == 7)
        {
            DeactivateMentor();

            questName = "quest name 7";
            questDesc = "quest desc 7";
            questObject4.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (activeQuest == 8)
        {
            questObject4.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        else if (activeQuest == 9)
        {
            DeactivateMentor();

            questName = "quest name 9";
            questDesc = "quest desc 9";
            questObject5.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (activeQuest == 10)
        {
            questObject5.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        else if (activeQuest == 11)
        {
            DeactivateMentor();

            questName = "quest name 11";
            questDesc = "quest desc 11";
            questObject6.GetComponent<BoxCollider2D>().enabled = true;

        }
        else if (activeQuest == 12)
        {
            questObject6.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        txtQuestText.text = questDesc.ToString();
    }
}
