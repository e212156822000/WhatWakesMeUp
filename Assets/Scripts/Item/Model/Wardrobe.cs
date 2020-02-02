using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : ItemEventBasic
{
    public AudioSource pullSound;
    // Start is called before the first frame update
    void Start()
    {
        pullSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
