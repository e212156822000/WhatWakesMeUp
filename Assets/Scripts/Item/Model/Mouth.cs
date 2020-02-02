using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : ItemEventBasic
{
    public AudioSource yawn;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Mouth;
        yawn = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
