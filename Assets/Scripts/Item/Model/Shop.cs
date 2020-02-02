using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Shop;   
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerState.hasWallet)//not sure
        {
            //Face.ChangeDoubtFace();//go see Office.cs or Playground.cs
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}