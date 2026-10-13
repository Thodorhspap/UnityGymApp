using UnityEngine;

public class PullUpsInteraction : MonoBehaviour
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
            // Increase arms and back stats of the capsule
            capsuleStats.IncreaseArms(2f); // Adjust the amount as needed
            capsuleStats.IncreaseBack(4f); // Adjust the amount as needed

            Debug.Log("Capsule interacted with Pull Ups. Arms and Back stats increased.");
        }
    }
}
