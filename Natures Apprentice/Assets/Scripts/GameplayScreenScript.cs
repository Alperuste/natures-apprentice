using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayScreenScript : MonoBehaviour
{
    [SerializeField]
    GameObject panelTutorial;
    [SerializeField]
    GameObject panelSettings;
    [SerializeField]
    GameObject panelBerryBook;
    public GameObject imgBlueBerry, txtBlueBerry, imgBogBerry, txtBogBerry, imgPineTree, txtPineTree, imgBirchTree, txtBirchTree, imgIceMoss, txtIcemoss, imgOrchid, txtOrchid, imgHerbParis, txtHerbParis;

    [SerializeField]
    int berryBookPage = 1;

    GameObject activeIMG, activeTXT;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTutorialPanel()
    {
        panelTutorial.active = true;
    }
    public void CloseTutorialPanel()
    {
        panelTutorial.active = false;
    }

    public void OpenSettingsPanel() {
        panelSettings.active = true;
    }

    public void CloseSettingsPanel() {
        panelSettings.active = false;
    }

    public void OpenBerryPanel()
    {
        panelBerryBook.active = true;
        ShowBerryPanelObjects();
    }
    public void CloseBerryPanel()
    {
        panelBerryBook.active = false;
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BerryPageUp()
    {
        if (berryBookPage >= 1 && berryBookPage < 7)
        {
            berryBookPage++;
        }
        else if (berryBookPage == 7)
        {
            berryBookPage = 1;
        }
        ShowBerryPanelObjects();
    }

    public void BerryPageDown()
    {
        if (berryBookPage <= 7 && berryBookPage >1)
        {
            berryBookPage--;
        }
        else if (berryBookPage == 1)
        {
            berryBookPage = 7;
        }
        ShowBerryPanelObjects();
    }

    public void ActivateBookPage(GameObject img, GameObject txt)
    {
        img.active = true;
        txt.active = true;
        activeIMG = img;
        activeTXT = txt;
    }
    public void DeActivateBookPage()
    {
        if (activeIMG != null && activeTXT != null)
        {
            activeIMG.active = false;
            activeTXT.active = false;

        }
    }

    public void ShowBerryPanelObjects()
    {
        //1 berry 2 bog berry 3 orchid 4 moss 5 herb 6 pine tree 7 birch tree
        if (berryBookPage == 1)
        {
            DeActivateBookPage();
            ActivateBookPage(imgBlueBerry, txtBlueBerry);
        }
        else if (berryBookPage == 2)
        {
            DeActivateBookPage();
            ActivateBookPage(imgBogBerry, txtBogBerry);
        }
        else if (berryBookPage == 3)
        {
            DeActivateBookPage();
            ActivateBookPage(imgOrchid, txtOrchid);
        }
        else if (berryBookPage == 4)
        {
            DeActivateBookPage();
            ActivateBookPage(imgIceMoss, txtIcemoss);
        }
        else if (berryBookPage == 5)
        {
            DeActivateBookPage();
            ActivateBookPage(imgHerbParis, txtHerbParis);
        }
        else if (berryBookPage == 6)
        {
            DeActivateBookPage();
            ActivateBookPage(imgPineTree, txtPineTree);
        }
        else if (berryBookPage == 7)
        {
            DeActivateBookPage();
            ActivateBookPage(imgBirchTree, txtBirchTree);
        }
    }


}
