using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dream : ItemEventBasic
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeSelf == true && PlayerState.hasDream == false)
        {
            PlayerState.hasDream = true;
        }
    }
}
