using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerInicio : MonoBehaviour
{
    public string LoadScene;

    
    public void CambiarEscena()
    {
        SceneManager.LoadScene(LoadScene);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Menu(string menu)
    {
        SceneManager.LoadScene(menu);
    }


}
