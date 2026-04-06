using UnityEngine;
using System.Collections;

public class SpittingBook : MonoBehaviour
{
    public GameObject ingredientCanvas;
    public float shakeIntensity = 0.05f;
    public float shakeDuration = 0.5f;

    private Vector3 originalPos;
    private bool isOpen = false;

    void Start()
    {
        originalPos = transform.localPosition;
        if (ingredientCanvas != null) ingredientCanvas.SetActive(false);
    }

    public void InteractWithBook()
    {
        if (!isOpen)
        {
            // Shake and Spit!
            StartCoroutine(ShakeAndShow());
        }
        else
        {
            // Disappear!
            ingredientCanvas.SetActive(false);
            isOpen = false;
        }
    }

    IEnumerator ShakeAndShow()
    {
        float elapsed = 0f;
        while (elapsed < shakeDuration)
        {
            // Jiggles the book around
            transform.localPosition = originalPos + (Random.insideUnitSphere * shakeIntensity);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originalPos; // Back to normal
        ingredientCanvas.SetActive(true);
        isOpen = true;
    }
}