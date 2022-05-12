using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsUpFloor : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKey("up"))
        {
            
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        }
    }
}
