using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : ItemEventBasic
{
    public AudioSource errorBugSound;

    // Start is called before the first frame update
    void Start()
    {
        errorBugSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
