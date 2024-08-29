using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectoDanino : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.tag);
            var playerAnimator = collision.gameObject.GetComponent<Animator>();
            playerAnimator.SetBool("Damage", true);
            var playerScript = collision.gameObject.GetComponent<PlayerScript>();
            playerScript.life -= 0.1f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var playerAnimator = collision.gameObject.GetComponent<Animator>();
            playerAnimator.SetBool("Damage", false);
        }
    }
}
