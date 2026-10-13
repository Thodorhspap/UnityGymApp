using UnityEngine;
using UnityEngine.UI;

public class InteractionPrompt : MonoBehaviour
{
    public GameObject promptUI; // Reference to the UI element displaying the prompt

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(true); // Show the prompt UI when the player enters the collider
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptUI.SetActive(false); // Hide the prompt UI when the player exits the collider
        }
    }

    // Add more functionality here to handle player interaction with the object
}
