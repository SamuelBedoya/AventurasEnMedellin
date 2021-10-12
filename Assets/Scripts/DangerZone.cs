using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DangerZone : MonoBehaviour
{
    public Text txtvida;
    public static int Vida = 100;

    public static bool alive = true;
    

    private void Start()
    {
        txtvida.text = "" + Vida + "%";
    }

    private void Update()
    {
        txtvida.text = "" + Vida + "%";
       
    }

    #region OriginalDangerZone

    private void DestroyPlayer()
    {
        alive = false;
        
        if (Vida != 0) Destroy(SceneControllerN1.Single.gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DestroyPlayer();
            Vida -= 10;
        }

    }
    #endregion

    #region DangerProfe
    /*
    private Vector2 newSpawn;
    public static float waitTimeToSpawn = 0.1f;
    private IEnumerator DestroyPlayer(GameObject  go)
    {
        if (Vida == 0)
        {
            yield break;

        }

        alive = false;
        go.SetActive(false);
        yield return new WaitForSeconds(waitTimeToSpawn);
        //Move player
        go.transform.position = newSpawn;
        //Active player
        go.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Vida != 0)
        {

            StartCoroutine(DestroyPlayer(collision.gameObject));
            Vida -= 10;


        }
        else Destroy(SceneControllerN1.Single.gameObject);
    */

    #endregion

}
    

