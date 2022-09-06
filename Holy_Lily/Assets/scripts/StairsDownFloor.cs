using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsDownFloor : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
    public bool playerIsClose;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerIsClose = false;

        }
    }
}
