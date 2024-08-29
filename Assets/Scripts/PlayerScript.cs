using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float life = 100f;
    public float speed = 2.5f;
    public float jump = 5f;
    public Animator animator;
    public Transform trans;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        int dirHor = 0;
        var escala = new Vector3(trans.localScale.x, trans.localScale.y, trans.localScale.z);

        if (Input.GetKey("a"))
        {
            dirHor = -1;
            escala.x = -Math.Abs(trans.localScale.x);
        }
        if (Input.GetKey("d"))
        {
            dirHor += 1;
            escala.x = Math.Abs(trans.localScale.x);
        }

        trans.localScale = escala;

        rb.velocity = new Vector2(dirHor * speed, rb.velocity.y);

        animator.SetFloat("Movimiento", dirHor);

        if (Input.GetKey("space") && Patas.inGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }

        if (Input.GetKeyDown("r"))
        {
            var caja = GameObject.FindGameObjectWithTag("CAJA");
            var otra = Instantiate(caja);
            var pos = new Vector2(rb.transform.position.x, rb.transform.position.y - 0.1f);
            otra.transform.position = pos;
        }

        if(life <= 0)
        {
            life = 20f;
            trans.position = new Vector2(-6.231782f, -3.405f - 0.1f);
        }
    }
}
