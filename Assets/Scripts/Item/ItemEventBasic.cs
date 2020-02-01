using UnityEngine;
using UnityEngine.Events;

public class ItemEventBasic : MonoBehaviour
{
    public UnityEvent itemEvent;

    public void Awake()
    {
        this.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;
        this.gameObject.AddComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        this.gameObject.AddComponent<DragHandler>();
    }
}
