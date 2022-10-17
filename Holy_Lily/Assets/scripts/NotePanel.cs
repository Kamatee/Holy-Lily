using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePanel : MonoBehaviour
{


    public GameObject notePanel;
    public Text noteText;
    public string note;
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
                noteText.text = note;
            }
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
            notePanel.SetActive(false);
        }
    }
}
