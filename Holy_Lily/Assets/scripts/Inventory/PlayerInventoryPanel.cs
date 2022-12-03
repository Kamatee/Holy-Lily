using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryPanel : MonoBehaviour
{
    public GameObject inventoryPanel;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryPanel.activeInHierarchy)
            {
                inventoryPanel.SetActive(false);
            }
            else
            {
                inventoryPanel.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            if (inventoryPanel.activeInHierarchy)
            {
                inventoryPanel.SetActive(false);
            }
        }
    }
}
