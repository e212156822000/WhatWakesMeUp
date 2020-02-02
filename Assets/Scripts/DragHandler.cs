using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour
{
    private float startPositionX;
    private float startPositionY;
    public bool isBeingHeld = false;

    void Update()
    {
        DragItem();
    }

    public void DragItem()
    {
        if (isBeingHeld)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPositionX, mousePos.y - startPositionY, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isBeingHeld)
        {
            ItemManager.firstClickedItem = this.gameObject;
            ItemManager.secondClickedItem = other.gameObject;
        }
    }
    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            startPositionX = mousePos.x - this.transform.localPosition.x;
            startPositionY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        this.gameObject.tag = "Change";
    }
}
