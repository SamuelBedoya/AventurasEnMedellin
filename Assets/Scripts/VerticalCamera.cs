using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalCamera : MonoBehaviour
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
        position.y = SceneControllerN1.Single.transform.position.y + 0.4f;
        transform.position = position;

    }
}
