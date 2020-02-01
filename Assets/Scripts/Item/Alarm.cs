using UnityEngine;

public class Alarm : ItemEventBasic
{
    public AudioSource ringSound;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = ItemNameDictionary.Alarm;
        RingRing(true);
        itemEvent.AddListener(StopAlarmEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopAlarmEvent()
    {
        RingRing(false);
        this.gameObject.SetActive(false);
    }

    public void RingRing(bool play)
    {
        if (ringSound != null)
        {
            if (play)
            {
                ringSound.Play();
            }
            else
            {
                ringSound.Stop();
            }
        }
    }
}
