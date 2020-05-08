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
    }
    public void CloseBerryPanel()
    {
        panelBerryBook.active = false;
    }
}
