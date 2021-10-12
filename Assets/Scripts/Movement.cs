using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float JumpForce;
    public float Speed;
    
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;

    public static Animator instance;

    private AudioSource JumpSound;


    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

        JumpSound = GetComponent<AudioSource>();
       
    }

    void Update()
    {
        

        //Voltear
        if (DangerZone.Vida != 0)
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            if (Horizontal < 0.0f) transform.localScale = new Vector2(-1.0f, 1.0f);
            else if (Horizontal > 0.0f) transform.localScale = new Vector2(1.0f, 1.0f);
        }
        

        //Control Animacion
        Animator.SetBool("run", Horizontal != 0.0f);
        Animator.SetBool("jump", Grounded == false);
        Animator.SetBool("death", DangerZone.Vida == 0);

        //Detector de piso
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.25f))
        {
            Grounded = true;
        }
        else Grounded = false;

        //Llama a Jump
        if (Input.GetKeyDown(KeyCode.W) ^ Input.GetKeyDown(KeyCode.Space) ^ Input.GetKeyDown(KeyCode.UpArrow) && Grounded && DangerZone.Vida != 0)
        {
            Jump();
            JumpSound.Play();
        }
    }

    private void FixedUpdate()
    {
        if (DangerZone.Vida == 0) return;
        //Caminar
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        
        //Saltar
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plataform")
        {
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataform")
        {
            transform.parent = null;
        }
    }






}
