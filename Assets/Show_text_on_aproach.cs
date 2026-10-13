using UnityEngine;
using TMPro;

public class ShowTextOnApproach : MonoBehaviour
{
    public GameObject textObject; // Assign the TextMeshPro GameObject in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.SetActive(false);
        }
    }
}