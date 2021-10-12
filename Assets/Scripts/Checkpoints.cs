using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public static Vector2 lastSpawnpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lastSpawnpoint = this.transform.position;

            #region Save
            PlayerPrefs.SetFloat("lastPlayerPosition_x", lastSpawnpoint.x);
            PlayerPrefs.SetFloat("lastPlayerPosition_y", lastSpawnpoint.y);
            #endregion
        }
    }



}
