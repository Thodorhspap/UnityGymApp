using UnityEngine;

public class AdviserInteraction : MonoBehaviour
{
    private bool isPlayerNearby = false;
    private CapsuleStats capsuleStats;
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

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
            CheckWeight();
        }
    }

    void CheckWeight()
    {
        if (capsuleStats != null)
        {
            float weight = capsuleStats.GetWeight();

            if (weight > 110)
            {
                Debug.Log("Lose some weight");
                ShowMessage("Lose some weight");
            }
            else if (weight < 70)
            {
                Debug.Log("Gain some weight");
                ShowMessage("Gain some weight");
            }
            else
            {
                Debug.Log("Your weight is perfect");
                ShowMessage("Your weight is perfect");
            }
        }
    }

    void ShowMessage(string message)
    {
        if (uiManager != null)
        {
            uiManager.ShowMessage(message);
        }
    }
}
