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
    }
}
