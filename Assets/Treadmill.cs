using UnityEngine;

public class TreadmillInteraction : MonoBehaviour
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
            // Increase legs stat of the capsule
            capsuleStats.IncreaseLegs(2f); // Adjust the amount as needed

            Debug.Log("Capsule interacted with Treadmill. Legs stat increased.");
        }
    }
}