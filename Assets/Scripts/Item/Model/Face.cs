using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Face
{
    public static UnityEvent GetFaceEvent(UnityAction call)
    {
        UnityEvent faceEvent = new UnityEvent();
        faceEvent.AddListener(call);
        return faceEvent;
    }

    public static void ChangeWakeUpFace()
    {
        FaceManager.ChangeFace("(っ﹏-) .｡o");
    }

    public static void ChangeNormalFace()
    {
        FaceManager.ChangeFace("(o´ω`o)ﾉ");
    }

    public static void ChangeNormalFace2()
    {
        FaceManager.ChangeFace("(o°ω°o)");
    }

    public static void ChangeTerrifyFace()
    {
        FaceManager.ChangeFace("Σ(ﾟДﾟ；≡；ﾟдﾟ)");
    }
}
