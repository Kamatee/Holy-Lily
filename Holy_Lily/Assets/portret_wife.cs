using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portret_wife : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            anim.Play("wife_on_fire");
        }

    }
}
