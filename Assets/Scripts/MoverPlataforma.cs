using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoverPlataforma : MonoBehaviour
{
    private Transform trans;
    private float speed = 10f;
    private Vector3 original;
    private bool derecha;

    public void Awake()
    {
        trans = GetComponent<Transform>();
        original = trans.position;
        derecha = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (derecha) {
            Vector3 vec = trans.position;
            vec.x += 0.01f;
            trans.Translate(vec);
        }
    }
}
