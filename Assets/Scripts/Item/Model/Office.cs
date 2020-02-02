using UnityEngine;

public class Office : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Office;   
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerState.hasWallet)//not sure
        {
            FaceManager.Instance.ChangeDoubtFace();
        }
         else
         {
             this.gameObject.SetActive(false);
         }
    }
}