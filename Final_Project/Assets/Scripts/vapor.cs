using UnityEngine;

public class vapor : MonoBehaviour
{
    public ParticleSystem coldVapor; 

    void Start()
    {
        // This ensures the cold air doesn't leak out until you click it
        if (coldVapor != null) coldVapor.Stop(); 
    }

    public void ShiverAndSmoke()
    {
        if (coldVapor != null) 
        {
            coldVapor.Play();
        }
    }
}