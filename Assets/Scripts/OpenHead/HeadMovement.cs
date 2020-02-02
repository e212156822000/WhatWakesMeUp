using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : DragHandler
{
    public float headX;
    public float headZ;

    public AudioSource headMoveSound;
    public List<GameObject> startItem;
    public bool soundPlay = true;

    // Start is called before the first frame update
    void Start()
    {
        headX = gameObject.transform.position.x;
        headZ = gameObject.transform.position.z;
        headMoveSound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        DragItem();
        if (isBeingHeld)
        {
            if (!soundPlay)
            {
                headMoveSound.Play();
                soundPlay = true;
            }
            float mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            float limitBottomBorder = 1.759657f;
            if (mousePosY < limitBottomBorder) mousePosY = limitBottomBorder;
            gameObject.transform.localPosition = new Vector3(headX, mousePosY, headZ);
            if (mousePosY > 4f)
            {
                this.gameObject.SetActive(false);
                foreach (var item in startItem)
                {
                    item.SetActive(true);
                }
            }
        }
        else
        {
            if (soundPlay)
            {
                headMoveSound.Stop();
                soundPlay = false;
            }
        }
    }
}
