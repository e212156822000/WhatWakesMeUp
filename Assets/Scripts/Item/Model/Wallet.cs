using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : ItemEventBasic
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf && !PlayerState.hasWallet)
        {
            PlayerState.hasWallet = true;
        }
    }
}
