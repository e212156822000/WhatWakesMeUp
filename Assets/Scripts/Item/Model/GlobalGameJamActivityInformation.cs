using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameJamActivityInformation : ItemEventBasic
{
    // Start is called before the first frame update
    void Start()
    {
        name = ItemNameDictionary.GlobalGameJamActivityInformation;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerState.hasDream)
        {
            this.gameObject.SetActive(false);
        }
    }
}
