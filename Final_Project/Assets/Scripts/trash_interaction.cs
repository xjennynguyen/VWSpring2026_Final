using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TrashBagFeedback : MonoBehaviour
{
    private Vector3 originalScale;
    public float squashAmount = 0.9f; // How much it squishes down
    public float bounceSpeed = 10f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    // Call this from Hover Entered
    public void PlaySquish()
    {
        transform.localScale = new Vector3(originalScale.x * 1.1f, originalScale.y * squashAmount, originalScale.z * 1.1f);
    }

    // Call this from Hover Exited
    public void ResetScale()
    {
        transform.localScale = originalScale;
    }

    void Update()
    {
        // Smoothly bounce back to normal size
        transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime * bounceSpeed);
    }
}