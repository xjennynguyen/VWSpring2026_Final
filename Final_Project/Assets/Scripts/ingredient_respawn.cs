using UnityEngine;

public class IngredientRespawn : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;
    public float thresholdY = -1f; 

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        if (transform.position.y < thresholdY)
        {
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}