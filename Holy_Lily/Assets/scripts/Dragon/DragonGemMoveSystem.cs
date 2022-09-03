using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragonGemMoveSystem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler,IDragHandler
{
    private RectTransform rectTrans;
    public Canvas myCanvas;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta/myCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("End");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Start");
    }

    /*public GameObject correctForm;
private bool moving;

private float startPosX;
private float startPosY;

void Start()
{

}

void Update()
{
   if (moving)
   {
       Vector3 mousePos;
       mousePos = Input.mousePosition;
       mousePos = Camera.main.ScreenToWorldPoint(mousePos);

       this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX,mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
   }
}

private void OnMouseDown()
{
   if (Input.GetMouseButtonDown(0))
   {
       Vector3 mousePos;
       mousePos = Input.mousePosition;
       mousePos = Camera.main.ScreenToWorldPoint(mousePos);

       startPosX = mousePos.x = this.transform.localPosition.x;
       startPosY = mousePos.y = this.transform.localPosition.y;

       moving = true;

   }

}

private void OnMouseUp()
{
   moving = false;
}*/

}
