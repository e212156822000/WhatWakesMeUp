using UnityEngine;

public class Door : ItemEventBasic
{
    public AudioSource openDoor;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Door;
        openDoor = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
