using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject optMenu;


    

    public void OpenPanel(GameObject panel)
    {
        optMenu.SetActive(false);
        menu.SetActive(false);

        panel.SetActive(true);

    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
        DangerZone.Vida = 100;
        Score.puntos = 0;
    }

}


