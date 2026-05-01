using UnityEngine;

public class TomDance : MonoBehaviour
{
    public float bounceSpeed = 5f;
    public float bounceHeight = 0.2f;
    public float rotateSpeed = 100f;
    
    private Vector3 startPos;

    void Start()
    {
        // Save the starting position so he stays in the same spot while dancing
        startPos = transform.position;
    }

    void Update()
    {
        // 1. The Bounce: Uses a Sine wave to move him up and down
        float newY = startPos.y + Mathf.Abs(Mathf.Sin(Time.time * bounceSpeed)) * bounceHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);

        // 2. The Spin: Rotates him around his center
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}