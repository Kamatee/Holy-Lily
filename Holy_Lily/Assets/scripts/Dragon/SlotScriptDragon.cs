using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScriptDragon : MonoBehaviour, IDropHandler
{
    public int id;
    
    public void OnDrop(PointerEventData eventData)
    {
        //sprawdzanie ID
        if (eventData.pointerDrag.GetComponent<DragonGemMoveSystem>().id == id)
        {
            Debug.Log("Correct");
            GameObject.Find("PointHandler").GetComponent<DragonWin>().AddPoints();
        }
        else
        {
            Debug.Log("False");
        }

        if (eventData.pointerDrag != null)
        {
            //uk�ada item w �rodku # nie dzia�a dobrze
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
