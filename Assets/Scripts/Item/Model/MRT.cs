using UnityEngine;

public class MRT : ItemEventBasic
{
    public AudioSource sounds;
    public AudioClip walkToMRT;
    public AudioClip police;
    private bool startEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.MRT;
        sounds = this.gameObject.GetComponent<AudioSource>();
        startEnd = true;
        sounds.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerState.isWearingClothes)
        {
            sounds.Stop();
            sounds.PlayOneShot(walkToMRT);
            FaceManager.Instance.ChangeNormalFace2();
        }
        else if (startEnd && !PlayerState.isWearingClothes)
        {
            sounds.Stop();
            sounds.PlayOneShot(police);
            FaceManager.Instance.ChangeTerrifyFace();
            EndingManager.Instance.PlayEndEvent();
            startEnd = false;
        }
    }
}
