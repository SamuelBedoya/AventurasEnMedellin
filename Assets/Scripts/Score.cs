using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int puntos;
    public Text TXTpuntos;
    public static string txtpuntos;
    public string Nivel;

    private int totales = 5;

    void Update()
    {
        if (TXTpuntos == null) return;

        TXTpuntos.text = "" + puntos;
        txtpuntos = TXTpuntos.text;

        if (puntos == totales)
        {
            StartCoroutine("Win");
        }

    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(Nivel);
        DangerZone.Vida = 100;
        puntos = 0;
    }


}
