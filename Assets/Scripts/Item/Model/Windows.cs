using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : ItemEventBasic
{
    public AudioSource windows;

    // Start is called before the first frame update
    void Start()
    {
        windows = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
