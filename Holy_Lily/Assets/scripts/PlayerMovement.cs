using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    //zmienna do zmiany animacji ¿eby gracz szed³ w lewo
    private SpriteRenderer sprite;
    private Animator anim;
    private float dirX= 0f;

    [SerializeField] float moveSpeed = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        //kied lewy shift wciœniety postaæ przyœpiesza
        if (Input.GetKey(KeyCode.LeftShift))
        {             
            moveSpeed = 9f;
            anim.SetBool("run", true);
        }
        else
        {
            moveSpeed = 4f;
            anim.SetBool("run", false);
        }
        
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        UpdateAnimation();

        // poruszanie siê w prawo lewo przed dodanie biegania
        //dirX = Input.GetAxisRaw("Horizontal");
        //rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        //UpdateAnimation();



    }

    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            anim.SetBool("walk", true);
            //posatc przy chodzeniu w prawo zmienia strone
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("walk", true);
            //posatc przy chodzeniu w lewo zmienia strone
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

}

