using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : ItemEventBasic
{
    public AudioSource keyboardSound;
    // Start is called before the first frame update
    void Start()
    {
        keyboardSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
