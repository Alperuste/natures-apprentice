using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstDialogsScript : MonoBehaviour
{
    [SerializeField]
    GameObject panelTutorial;
    [SerializeField]
    GameObject panelFirstDialog;
    [SerializeField]
    Text txtFirstDialog;
    [SerializeField]
    PlayerScript playerScript;

    int dialog = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            dialog++;
        }
        ChangeText();
    }

    void ChangeText()
    {

        // if (dialog == 1)
        // {
        //     txtFirstDialog.text = "";
        // }
         if (dialog == 1)
        {
            txtFirstDialog.text = "[Rasmus] You knew him, old man? I want to find out what happened to him. If training in herbalism helps me do so, then yes, I’ll do it! ";
        }
        else if (dialog == 2)
        {
            txtFirstDialog.text = "[Jaak] All in due time, let’s begin.";
        }
        // else if (dialog == 4)
        // {
        //     txtFirstDialog.text = "[Jaak] Your father. Anybody ever tell you that?";
        // }
        // else if (dialog == 5)
        // {
        //     txtFirstDialog.text = "[Rasmus] What? No! Did you know my father? Where is he? What was he like?";
        // }
        // else if (dialog == 6)
        // {
        //     txtFirstDialog.text = "[Jaak] Ha! So many questions, young lad. Very much like him indeed.Yes I knew him, the best herbalist in the land. That’s high praise I might add, I used to train him after all.";
        // }
        // else if (dialog == 7)
        // {
        //     txtFirstDialog.text = "[Rasmus] A herbalist? And you trained him? Do you know where he is now?";
        // }
        // else if (dialog == 8)
        // {
        //     txtFirstDialog.text = "[Jaak] Your mother really told you nothing about him? Well he was a very intuitive herbalist and a quick study as well.In fact, he quickly outgrew me, these old legs aren’t what they used to and he could explore the woods faster than I could.Your father and I worked together a long time, until…";
        // }
        // else if (dialog == 9)
        // {
        //     txtFirstDialog.text = "[Rasmus] Until what?";
        // }
        // else if (dialog == 10)
        // {
        //     txtFirstDialog.text = "[Jaak] Quit interrupting me, boy! Where was I? Ah yes, until he got a job to find a rare flower and never returned.";

        // }
        // else if (dialog == 11)
        // {
        //     txtFirstDialog.text = "[Rasmus] What happened to him? Where did you last see him?";
        // }
        // else if (dialog == 12)
        // {
        //     txtFirstDialog.text = "[Jaak] All in due time. Only an intuitive herbalist, just like your father was, can hope to find him and the flower he was sent to collect.Now, I have a kettle on inside, want some tea?";
        // }
        // else if (dialog == 13)
        // {
        //     txtFirstDialog.text = "[Rasmus] Wait! You said you mentored my father. Will you teach me as well?";
        // }
        // else if (dialog == 14)
        // {
        //     txtFirstDialog.text = "[Jaak] Hmm. What do you know about the nature, boy? Being a herbalist takes time, it takes dedication.It isn’t for everyone.";
        // }
        // else if (dialog == 15)
        // {
        //     txtFirstDialog.text = "[Rasmus] I am dedicated! I want to find my father. And following his footsteps will help me do so! My mother never taught me anything about the nature, she even forbade me to go to the forest.But I am ready to learn now!";
        // }
        // else if (dialog == 16)
        // {
        //     txtFirstDialog.text = "[Jaak] Your eagerness is appreciated.Too bad we have to start from scratch, this will take time.Time we don’t have.";
        // }
        // else if (dialog == 17)
        // {
        //     txtFirstDialog.text = "[Rasmus] What do you mean?";
        // }
        // else if (dialog == 18)
        // {
        //     txtFirstDialog.text = "[Jaak] Oh, nothing.Your training will start soon.Prepare yourself!";
        // }
        else if (dialog == 3)
        {
            //panelTutorial.active = true;
            //playerScript.enabled = true;
            panelFirstDialog.active = false;

            FindObjectOfType<PlayerScript>().isFirstDialogDone = true;
            print("First Dialog Done");
        }
    }

}
