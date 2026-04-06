using UnityEngine;
using TMPro;

public class CatTeacher : MonoBehaviour
{
    public TextMeshProUGUI catSpeech;
    private int itemsStacked = 0;
    private bool isDancing = false;

    void Start()
    {
        catSpeech.text = "Hey! Welcome. Grab a bottom bun and put the meat on!";
        isDancing = false; // Make sure he starts still
    }

    void Update()
    {
        // Only spin IF the top bun has been placed
        if (isDancing)
        {
            transform.Rotate(0, 200 * Time.deltaTime, 0); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 1. Check if it's an ingredient
        if (other.CompareTag("Ingredient"))
        {
            // 2. Check if it is the TOP BUN
            if (other.name == "burgerBun_Top")
            {
                catSpeech.text = "You did it! That looks amazing.";
                isDancing = true; // START DANCING NOW
            }
            else
            {
                // 3. If it's just meat or cheese, don't dance yet!
                itemsStacked++;
                UpdateCatBrain();
            }
        }
    }

    void UpdateCatBrain()
    {
        // This keeps the cat on the middle message
        if (itemsStacked >= 1 && !isDancing)
        {
            catSpeech.text = "Great! Now add all the toppings needed. When done add top bun.";
        }
    }
}