using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePanel : MonoBehaviour
{
    public GameObject notePanel;
    public Text noteText;
    public string[] note;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;

 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (notePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                notePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (noteText.text == note[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        noteText.text = "";
        index = 0;
        notePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in note[index])
        {
            noteText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);
        if(index < note.Length - 1)
        {
            index++;
            noteText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
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
            zeroText();
        }
    }
}
