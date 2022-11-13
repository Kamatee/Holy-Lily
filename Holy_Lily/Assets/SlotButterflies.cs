using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotButterflies : MonoBehaviour, IDropHandler
{
    [SerializeField] public int id;

    public void OnDrop(PointerEventData eventData)
    {
        //sprawdzanie ID
        if (eventData.pointerDrag.GetComponent<MoveSystem>().id == id)
        {
            Debug.Log("Correct");
            GameObject.Find("PointHandler").GetComponent<ButterflyWins>().AddPoints();
        }
        else
        {
            Debug.Log("False");
        }

        if (eventData.pointerDrag != null)
        {
            //uk³ada item w œrodku # nie dzia³a dobrze
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
