using UnityEngine;

public class SitUpsInteraction : MonoBehaviour
{
    private bool isPlayerNearby = false;
    private CapsuleStats capsuleStats;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            capsuleStats = other.GetComponent<CapsuleStats>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            capsuleStats = null;
        }
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        if (capsuleStats != null)
        {
            // Increase core stat of the capsule
            capsuleStats.IncreaseCore(5f); // Adjust the amount as needed

            Debug.Log("Capsule interacted with Sit Ups. Core stat increased.");
        }
    }
}