using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour
{
    private float startPositionX;
    private float startPositionY;
    private bool isBeingHeld = false;

    void Update()
    {
        if(isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPositionX, mousePos.y - startPositionY, 0);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        flag.firstClickedItem = this.gameObject;
        flag.secondClickedItem = other.gameObject;
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
        Debug.Log(flag.firstClickedItem.name);
        Debug.Log(flag.secondClickedItem.name);
    }
}
