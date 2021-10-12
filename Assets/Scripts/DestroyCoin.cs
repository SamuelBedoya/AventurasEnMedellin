using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCoin : MonoBehaviour
{
    private AudioSource Sonido;
    private SpriteRenderer Imagen;

    private void Start()
    {
        Sonido = GetComponent<AudioSource>();
        Imagen = GetComponent<SpriteRenderer>();
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject,0.5f);
        Destroy(Imagen);
        Score.puntos = Score.puntos + 1;
        Sonido.Play();
    }
}
