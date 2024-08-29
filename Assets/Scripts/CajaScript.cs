using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaScript : MonoBehaviour
{
    
    private float life;

    private void Awake()
    {
        life = 20f;
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            life -= 1;
            if (life <= 0)
            {
                var personaje = collision.gameObject.GetComponent<Transform>();
                personaje.localScale = new Vector3(personaje.localScale.x + 0.25f, personaje.localScale.y + 0.25f, personaje.localScale.z + 0.25f);
                Destroy(this.gameObject);
            }
        }
    }

}
