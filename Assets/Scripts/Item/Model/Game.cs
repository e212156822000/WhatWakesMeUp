using UnityEngine;

public class Game : ItemEventBasic
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Game;   
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerState.hasWallet)//not sure
        {
            //Face.ChangeDoubtFace();//not needed because already in Office.cs
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}