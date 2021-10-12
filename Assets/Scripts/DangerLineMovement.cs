using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerLineMovement : MonoBehaviour
{
    //public GameObject line;
    
    public Transform start;
    public Transform end;
    public float velocity;

    private Vector3 moverHacia;

    private void Start()
    {
        moverHacia = end.position;
        
        transform.position = start.position;
    }

    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moverHacia, velocity * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position = start.position;
        }
    }


}
