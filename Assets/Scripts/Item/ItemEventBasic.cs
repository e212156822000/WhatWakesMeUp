using UnityEngine;
using UnityEngine.Events;

public class ItemEventBasic : MonoBehaviour
{
    public UnityEvent itemEvent;

    public void Awake()
    {
        this.gameObject.AddComponent<PolygonCollider2D>();
        this.gameObject.AddComponent<Rigidbody2D>().gravityScale = 0;
        this.gameObject.AddComponent<DragHandler>();
        this.gameObject.AddComponent<RandomMovement>();
    }
}
