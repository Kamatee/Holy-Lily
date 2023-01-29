using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    [SerializeField] public GameObject notePanel;
    [SerializeField] public bool playerIsClose;
    [SerializeField] private int num;

    // Update is called once per frame
    void Update()
    {
        if (playerIsClose == true && num == 0)
        {
            notePanel.SetActive(true);
        }
            else
            {
                notePanel.SetActive(false);
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
            if (num == 0)
            {
                num = num + 1;
            }
        }
    }
}
