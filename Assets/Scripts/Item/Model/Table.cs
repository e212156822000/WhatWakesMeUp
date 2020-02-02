using UnityEngine;

public class Table : ItemEventBasic
{
    public AudioSource tableKnock;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Table;
        tableKnock = gameObject.GetComponent<AudioSource>();
    }
}
