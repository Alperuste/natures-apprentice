using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    [SerializeField]
    GameObject dialogPanel;
    [SerializeField]
    Text dialogText;

    bool canCloseDialog = false;

    public GameObject questObject1;
    public GameObject questObject2;
    public GameObject questObject3;
    public GameObject questObject4;


    [HideInInspector]
    public string questDialog;

    [SerializeField]
    GameObject theEndPanel;
    [SerializeField]
    GameObject findItPanel;
    [SerializeField]
    Text findItText;

    // Start is called before the first frame update
    void Start()
    {
        QuestActivate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canCloseDialog == true)
        {
            dialogPanel.active = false;
            canCloseDialog = false;

            if (activeQuest >= 9)
            {
                theEndPanel.active = true;
                Invoke("GoToCreditsScene", 3f);
            }
        }
    }

    public void openFindIt()
    {
        findItPanel.active = true;
        if (activeQuest == 1)
        {
            findItText.text = "I find it!";
        }
        if (activeQuest == 3)
        {
            findItText.text = "I find it!";
        }
        if (activeQuest == 5)
        {
            findItText.text = "I find it!";
        }
        if (activeQuest == 7)
        {
            findItText.text = "I find it!";
        }
        Invoke("closefindIt",1f);
    }

    void closefindIt()
    {
        findItPanel.active = false;
    }

    public void GoToCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void closeDialog()
    {
        canCloseDialog = true;
    }

    public void openDialog()
    {
        dialogPanel.active = true;

        if (activeQuest == 0)
        {
            dialogText.text = "[Jaak] We need to start from the basics with you. I caught some fresh fish today. Would make a hearty dinner, wouldn’t you say? However I seem to be out of birch bark to smoke it. Gather some for me, will ya?";
        }
        else if (activeQuest == 2)
        {
            dialogText.text = "[Jaak] Ready for another task? In that case, I am in dire need of some blueberries! Quickly, go fetch me some!";
        }
        else if (activeQuest == 4)
        {
            dialogText.text = "[Jaak] (coughs) I think I caught something when I was out last night. Will you help me, boy? I need you to bring me some Icelandic Moss for my cough.";
        }
        else if (activeQuest == 6)
        {
            dialogText.text = "[Jaak] Ah, there you are. The tea has helped with my cough. It is now time for a final quest before we can move on with your education. I will now test your instincts about flowers. See, if you can find me a rare southern-marsh orchid.";
        }
        else if (activeQuest == 8)
        {
            dialogText.text = "[Jaak] You have proved to be just like your father. A quick study with a knack for finding the plants with just your intuition to guide you. You have earned the rank of Novice Herbalist. Don’t let it get to your head though, there is much work to be done.";
        }


        Invoke("closeDialog", 1.5f);
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
            questName = "Collect Birch Bark";
            questDesc = "Collect Birch Bark";
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
            questName = "Collect Blueberries";
            questDesc = "Collect Blueberries";
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

            questName = "Collect Icelandic Moss";
            questDesc = "Collect Icelandic Moss";
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

            questName = "Collect Marsh-Orchid";
            questDesc = "Collect Marsh-Orchid";
            questObject4.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (activeQuest == 8)
        {
            questObject4.GetComponent<BoxCollider2D>().enabled = false;

            questName = "Talk with Mentor";
            questDesc = "Talk with Mentor";
            ActivateMentor();

        }
        //else if (activeQuest == 9)
        //{
        //    DeactivateMentor();

        //    questName = "quest name 9";
        //    questDesc = "quest desc 9";
        //    questObject5.GetComponent<BoxCollider2D>().enabled = true;
        //}
        //else if (activeQuest == 10)
        //{
        //    questObject5.GetComponent<BoxCollider2D>().enabled = false;

        //    questName = "Talk with Mentor";
        //    questDesc = "Talk with Mentor";
        //    ActivateMentor();

        //}
        //else if (activeQuest == 11)
        //{
        //    DeactivateMentor();

        //    questName = "quest name 11";
        //    questDesc = "quest desc 11";
        //    questObject6.GetComponent<BoxCollider2D>().enabled = true;

        //}
        //else if (activeQuest == 12)
        //{
        //    questObject6.GetComponent<BoxCollider2D>().enabled = false;

        //    questName = "Talk with Mentor";
        //    questDesc = "Talk with Mentor";
        //    ActivateMentor();

        //}
        txtQuestText.text = questDesc.ToString();
    }
}
