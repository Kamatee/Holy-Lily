using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyPanelScript : MonoBehaviour
{
    public GameObject butterflyPanel;
    public bool playerIsClose;
    public int butterflyToUnlock = 0;
    [SerializeField] private AudioSource openPanelSound;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && butterflyToUnlock == 4)
        {
            if (butterflyPanel.activeInHierarchy)
            {
                butterflyPanel.SetActive(false);
            }
            else
            {
                openPanelSound.Play();
                butterflyPanel.SetActive(true);
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
            butterflyPanel.SetActive(false);
        }
    }
    public void ButterflyToUnlock()
    {
        butterflyToUnlock++;
        Debug.Log("liczba motyli: " + butterflyToUnlock);
    }


}
