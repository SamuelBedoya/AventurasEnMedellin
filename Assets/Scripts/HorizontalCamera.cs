using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalCamera : MonoBehaviour
{
    private AudioSource audioJuego;

    private void Awake()
    {
        audioJuego = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (SceneControllerN1.Single == null) return;

        Vector3 position = transform.position;
        position.x = SceneControllerN1.Single.transform.position.x;
        transform.position = position;

    }
}
