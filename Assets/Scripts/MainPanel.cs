using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainPanel : MonoBehaviour
{
    
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject levelsPanel;


    public void OpenPanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        levelsPanel.SetActive(false);

        panel.SetActive(true);

    }
    public void ChangeScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


}
