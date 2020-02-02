using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndingManager : Singleton<EndingManager>
{
    public bool startEnding = false;
    public bool badEnd = false;
    public bool trueEnd = false;
    public GameObject endingPic;
    public GameObject trueEndingPic;
    public Vector3 originPos;

    public GameObject badEndObj;

    float t;
    Vector3 startPosition;
    Vector3 target;
    float timeToReachTarget;

    // Start is called before the first frame update
    void Start()
    {
        originPos = endingPic.transform.position;
        startPosition = target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startEnding)
        {
            SetDestination(new Vector3(originPos.x, 0.4f, originPos.z), 1f);
            t += Time.deltaTime / timeToReachTarget;
            transform.position = Vector3.Lerp(startPosition, target, t);
            if (transform.position == target) startEnding = false;

            if (badEnd)
            {
                badEndObj.SetActive(true);
            }
            else if (trueEnd)
            {
                trueEndingPic.SetActive(true);
                AudioListener.pause = true;
            }
        }
    }

    public void PlayEndEvent()
    {
        startEnding = true;
    }

    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }

    public static UnityEvent GetEndEvent(UnityAction call)
    {
        UnityEvent endEvent = new UnityEvent();
        endEvent.AddListener(call);
        return endEvent;
    }

    public void GetTrueEnd()
    {
        startEnding = true;
        trueEnd = true;
    }
}
