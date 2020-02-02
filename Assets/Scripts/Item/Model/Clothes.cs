using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : ItemEventBasic
{
    public AudioSource clothesSound;
    // Start is called before the first frame update
    void Start()
    {
        this.name = ItemNameDictionary.Clothes;
        clothesSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
