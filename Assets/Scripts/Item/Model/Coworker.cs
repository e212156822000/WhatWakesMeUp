using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coworker : ItemEventBasic
{
    public AudioSource kkSound;
    // Start is called before the first frame update
    void Start()
    {
        kkSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
