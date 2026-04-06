using UnityEngine;

public class BurgerInteraction : MonoBehaviour
{
    // Drag your Canvas into this slot in the Inspector
    public GameObject factCanvas;

    // Call this when the burger is grabbed
    public void ShowFact()
    {
        factCanvas.SetActive(true);
        Debug.Log("Learning fact activated!");
    }

    // Call this when the burger is dropped
    public void HideFact()
    {
        factCanvas.SetActive(false);
    }
}