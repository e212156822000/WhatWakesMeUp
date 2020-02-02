using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float rotationAngle;
    public float speedX;
    public float speedY;
    void Start()
    {
        Random.seed = System.Guid.NewGuid().GetHashCode();
        GetAngle();
        speedX = Random.Range(0.1f, 1.0f);
        speedY = Random.Range(0.1f, 1.0f);
    }

    void Update()
    {
        this.gameObject.transform.TransformVector(speedX, speedY, 0.0f);
        this.gameObject.transform.Rotate(new Vector3(0, 0, rotationAngle));
        if (this.gameObject.tag == "Change")
        {
            GetAngle();
            this.gameObject.tag = "Collision";
        }
        
    }

    private void GetAngle()
    {
        rotationAngle = Random.Range(-0.05f, 0.05f);
        if (rotationAngle > -0.015f && rotationAngle < 0.015f) rotationAngle *= 3;
    }
}