
using UnityEngine;

public class ReceptionInteraction : MonoBehaviour
{
    public GameObject uiPanel; // Reference to the main UI panel
    public GameObject statsPanel; // Reference to the stats panel
    public GameObject dietOptionsPanel; // Reference to the diet options panel
    public GameObject gymPlanPanel; // Reference to the gym plan options panel
    public GameObject shopPanel; // Reference to the shop panel
    public GameObject upperBodyPanel; // Reference to the upper body panel
    public GameObject lowerBodyPanel; // Reference to the lower body panel
    public GameObject balancedPanel; // Reference to the balanced panel
    public GameObject loseWeightTextPanel ;
    public GameObject gainWeightTextPanel;

    private bool isInRange = false;

    void Start()
    {
        // Ensure all panels are initially hidden
        uiPanel.SetActive(false);
        statsPanel.SetActive(false);
        dietOptionsPanel.SetActive(false);
        gymPlanPanel.SetActive(false);
        shopPanel.SetActive(false);
        upperBodyPanel.SetActive(false);
        lowerBodyPanel.SetActive(false);
        balancedPanel.SetActive(false);
    }

    void Update()
    {
        // Check if player is in range and presses the interact key (e.g., "E")
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Toggle visibility of the UI panel
            uiPanel.SetActive(!uiPanel.activeSelf);

            // Hide other panels if they are active
            if (uiPanel.activeSelf)
            {
                statsPanel.SetActive(false);
                dietOptionsPanel.SetActive(false);
                gymPlanPanel.SetActive(false);
                shopPanel.SetActive(false);
                upperBodyPanel.SetActive(false);
                lowerBodyPanel.SetActive(false);
                balancedPanel.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player capsule enters the reception area
        if (other.CompareTag("Player"))
        {
            isInRange = true;

            // Hide the shop panel and other gym plan panels when entering reception area
            shopPanel.SetActive(false);
            upperBodyPanel.SetActive(false);
            lowerBodyPanel.SetActive(false);
            balancedPanel.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the player capsule exits the reception area
        if (other.CompareTag("Player"))
        {
            isInRange = false;

            // Hide all panels when player leaves
            uiPanel.SetActive(false);
            statsPanel.SetActive(false);
            dietOptionsPanel.SetActive(false);
            gymPlanPanel.SetActive(false);
            shopPanel.SetActive(false);
            upperBodyPanel.SetActive(false);
            lowerBodyPanel.SetActive(false);
            balancedPanel.SetActive(false);
            gainWeightTextPanel.SetActive(false);
            loseWeightTextPanel.SetActive(false);
        }
    }
}
