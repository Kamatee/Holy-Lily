using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragonPanel : MonoBehaviour
{
    public GameObject notePanel;
    public bool playerIsClose;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (notePanel.activeInHierarchy)
            {
                notePanel.SetActive(false);
            }
            else
            {
                notePanel.SetActive(true);
            }
        }
    }
    //
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
            notePanel.SetActive(false);
        }
    }
}
