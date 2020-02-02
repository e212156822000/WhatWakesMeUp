using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsMovement : DragHandler
{
    public float headX;
    public float headZ;

    // Start is called before the first frame update
    void Start()
    {
        headX = gameObject.transform.position.x;
        headZ = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        DragItem();
        if (isBeingHeld)
        {
            float mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            float limitBottomBorder = 0.93f;
            if (mousePosY < limitBottomBorder) mousePosY = limitBottomBorder;
            gameObject.transform.localPosition = new Vector3(headX, mousePosY, headZ);
            if (mousePosY > 4f)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
