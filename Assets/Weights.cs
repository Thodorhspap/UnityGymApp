using UnityEngine;

public class Weights : MonoBehaviour
{
    private bool isPlayerNearby = false;
    private CapsuleStats capsuleStats;

    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            if (capsuleStats != null)
            {
                capsuleStats.IncreaseArms(1f);
                capsuleStats.IncreaseCore(0f);
                capsuleStats.IncreaseLegs(0f);
                capsuleStats.IncreaseChest(3f);
                capsuleStats.IncreaseBack(0f);

                Debug.Log("Capsule interacted with weights. Stats increased.");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            capsuleStats = other.GetComponent<CapsuleStats>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            capsuleStats = null;
        }
    }
}
