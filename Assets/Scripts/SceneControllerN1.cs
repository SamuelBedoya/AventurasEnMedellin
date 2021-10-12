using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControllerN1 : MonoBehaviour
{
    public string GameOver;
    public GameObject Player;
    public Vector2 Spawn;
    private Vector2 lastPlayerPosition;
    private string lastPlayerScore;
    public static GameObject Single;

    #region Save
    private void Awake()
    {
        lastPlayerPosition = new Vector2(
                                          x: PlayerPrefs.GetFloat("lastPlayerPosition_x", Spawn.x),
                                          y: PlayerPrefs.GetFloat("lastPlayerPosition_y", Spawn.y)
                                         );
    }
    #endregion

    private void Start()
    {
        Single = Object.Instantiate(Player.gameObject, Spawn, Quaternion.identity);
    }


    private void Update()
    {
       /* if (DangerZone.Vida == 0) 
        {
            SceneManager.LoadScene(GameOver);
            DangerZone.Vida = 100;
            Score.puntos = 0;   
        } */

        if (DangerZone.alive == false) 
        {
            Single = Object.Instantiate(Player.gameObject, Checkpoints.lastSpawnpoint, Quaternion.identity);
            DangerZone.alive = true;
        }

        if (DangerZone.Vida == 0)
        {
            StartCoroutine("Muerte");
        }
    }

    IEnumerator Muerte()
    {
        yield return new WaitForSeconds(2f);
        Gameover();
    }

    private void Gameover()
    {
        SceneManager.LoadScene(GameOver);
        DangerZone.Vida = 100;
        Score.puntos = 0;

    }


}

