using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlataform : MonoBehaviour
{
    public GameObject plataform;
    public Transform start;
    public Transform end;
    public float velocity;

    private Vector3 moverHacia;

    private void Start()
    {
        moverHacia = end.position;

        plataform.transform.position = start.position;
    }


    private void Update()
    {
        plataform.transform.position = Vector3.MoveTowards(plataform.transform.position, moverHacia, velocity * Time.deltaTime);
        
        if(plataform.transform.position == end.position)
        {
            moverHacia = start.position;
        }

        if (plataform.transform.position == start.position)
        {
            moverHacia = end.position;
        }

    }
}
