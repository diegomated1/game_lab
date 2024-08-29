using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patas : MonoBehaviour
{
    public static bool inGround;
    public Animator animator;

    public void Awake()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inGround = true;
        animator.SetBool("Saltando", false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inGround = false;
        animator.SetBool("Saltando", true);
    }

}
