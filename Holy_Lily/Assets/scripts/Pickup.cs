using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public bool playerIsClose;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (playerIsClose == true && Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    GameObject.Find("Dragon").GetComponent<DragonPanel>().GemsToUnlock();
                    break;
                }
            }
        }
    }

    /* void OnTriggerEnter2D(Collider2D other)
     {
         if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
         {
             for (int i = 0; i < inventory.slots.Length; i++)
             {
                 if (inventory.isFull[i] == false)
                 {
                     //item can be added to inventory
                     inventory.isFull[i] = true;
                     Instantiate(itemButton, inventory.slots[i].transform, false);
                     Destroy(gameObject);
                     GameObject.Find("Dragon").GetComponent<DragonPanel>().GemsToUnlock();
                     break;
                 }
             }
         }
     }*/

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
