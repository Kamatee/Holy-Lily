using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    private int items = 0;

    [SerializeField] private Text itemText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="ItemToCollect")
        {
            
            Destroy(collision.gameObject);
            items++;
            itemText.text = "Items: " + items;
            
        }




    }
}
