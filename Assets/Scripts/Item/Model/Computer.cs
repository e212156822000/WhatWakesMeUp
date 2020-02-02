using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : ItemEventBasic
{
    public AudioSource comuterGameSound;
    // Start is called before the first frame update
    void Start()
    {
        comuterGameSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
