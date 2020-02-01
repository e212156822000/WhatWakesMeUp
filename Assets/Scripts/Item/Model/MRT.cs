using UnityEngine;

public class MRT : MonoBehaviour
{
    public AudioSource policeSound;
    private bool startEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.MRT;   
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerState.isWearingClothes)
        {
            FaceManager.Instance.ChangeNormalFace2();
        }
        else if (!startEnd && !PlayerState.isWearingClothes)
        {
            policeSound.Play();
            FaceManager.Instance.ChangeTerrifyFace();
            PlayEndEvent();
            this.gameObject.SetActive(false);
            startEnd = false;
        }
    }

    public void PlayEndEvent()
    {

    }
}
