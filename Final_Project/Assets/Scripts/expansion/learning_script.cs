using UnityEngine;
using TMPro;

public class IngredientInteraction : MonoBehaviour
{
    public GameObject factCanvas; 
    public TextMeshProUGUI factText; 
    [TextArea] public string ingredientFact; 

    private bool isShowing = false; // Tracks if the UI is open

    void Start() 
    {
        if (factCanvas != null) factCanvas.SetActive(false);
    }

    // Call this function to turn the fact on and off with one click
    public void ToggleFact() 
    {
        if (factCanvas == null || factText == null) return;

        isShowing = !isShowing; // Flips the switch (if true, becomes false)
        
        if (isShowing)
        {
            factText.text = ingredientFact;
            factCanvas.SetActive(true);
        }
        else
        {
            factCanvas.SetActive(false);
        }
    }

    // Keep this just in case you want a way to force it closed
    public void HideFact() 
    {
        isShowing = false;
        if (factCanvas != null) factCanvas.SetActive(false);
    }
}