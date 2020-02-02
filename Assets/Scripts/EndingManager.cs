using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : Singleton<EndingManager>
{
    public bool startEnding = false;
    public GameObject endingPic;
    public Vector3 originPos;

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
}
