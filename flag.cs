using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    public static GameObject firstClickedItem;
    public static GameObject secondClickedItem;
    // Start is called before the first frame update
    void Start()
    {
        firstClickedItem = this.gameObject;
        secondClickedItem = this.gameObject;
        Debug.Log(firstClickedItem.name);
        Debug.Log(secondClickedItem.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(firstClickedItem.name);
        // Debug.Log(secondClickedItem.name);
    }

}
