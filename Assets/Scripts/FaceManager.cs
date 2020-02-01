using UnityEngine;
using UnityEngine.UI;

public class FaceManager
{
    public static Text face;

    public static void ChangeFace(string text)
    {
        face.text = text;
    }
}
