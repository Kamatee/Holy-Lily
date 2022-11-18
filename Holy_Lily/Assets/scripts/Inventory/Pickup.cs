using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventorygem;
    private InventoryButterfly inventorybut;
    public GameObject itemButton;
    public bool playerIsClose;
    [SerializeField] public int objectId;


    private void Start()
    {
        inventorygem = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventorybut = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryButterfly>();
    }
    private void Update()
    {
        if (playerIsClose == true && Input.GetKeyDown(KeyCode.E) && objectId == 1)
        {
            for (int i = 0; i < inventorygem.slots.Length; i++)
            {
                if (inventorygem.isFull[i] == false)
                {
                    //item can be added to inventory(gem)
                    inventorygem.isFull[i] = true;
                    Instantiate(itemButton, inventorygem.slots[i].transform, false);
                    Destroy(gameObject);
                    GameObject.Find("Dragon").GetComponent<DragonPanel>().GemsToUnlock();
                    break;
                }
            }
        }
        else if (playerIsClose == true && Input.GetKeyDown(KeyCode.E) && objectId == 2)
        {
            for (int i = 0; i < inventorybut.slots.Length; i++)
            {
                if (inventorybut.isFull[i] == false)
                {
                    //item can be added to inventory(butterfly)
                    inventorybut.isFull[i] = true;
                    Instantiate(itemButton, inventorybut.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
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

        }
    }
}