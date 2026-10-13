using UnityEngine;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    public Button gymPlanButton;
    public Button dietPlanButton;
    public Button shopButton;
    public Button seeStatsButton; // Reference to the See Stats button
    public GameObject statsPanel; // Reference to the stats panel
    public GameObject dietOptionsPanel; // Reference to the diet options panel
    public GameObject gymPlanPanel; // Reference to the gym plan options panel
    public GameObject shopPanel; // Reference to the shop panel
    public Text statsText; // Reference to the Text component to display stats

    // References to the new gym plan options buttons
    public Button upperBodyButton;
    public Button lowerBodyButton;
    public Button balancedButton;

    // References to the text panels for gym plan options
    public GameObject upperBodyTextPanel;
    public GameObject lowerBodyTextPanel;
    public GameObject balancedTextPanel;

    // References to the diet plan options buttons
    public Button gainWeightButton;
    public Button loseWeightButton;

    // References to the text panels for diet plan options
    public GameObject gainWeightTextPanel;
    public GameObject loseWeightTextPanel;

    // References to the shop panel buttons
    public Button sitUpsButton;
    public Button deadliftButton;

    // References to the sit ups circle and deadlift cylinder
    public GameObject sitUpsCircle;
    public GameObject deadliftCylinder;

    private CapsuleStats capsuleStats;

    void Start()
    {
        gymPlanButton.onClick.AddListener(OnGymPlanClicked);
        dietPlanButton.onClick.AddListener(OnDietPlanClicked);
        shopButton.onClick.AddListener(OnShopClicked);
        seeStatsButton.onClick.AddListener(OnSeeStatsClicked);

        // Add listeners for the gym plan options buttons
        upperBodyButton.onClick.AddListener(OnUpperBodyClicked);
        lowerBodyButton.onClick.AddListener(OnLowerBodyClicked);
        balancedButton.onClick.AddListener(OnBalancedClicked);

        // Add listeners for the diet plan options buttons
        gainWeightButton.onClick.AddListener(OnGainWeightClicked);
        loseWeightButton.onClick.AddListener(OnLoseWeightClicked);

        // Add listeners for the shop panel buttons
        sitUpsButton.onClick.AddListener(OnSitUpsButtonClicked);
        deadliftButton.onClick.AddListener(OnDeadliftButtonClicked);

        capsuleStats = FindObjectOfType<CapsuleStats>();

        // Ensure all panels and objects are initially hidden
        statsPanel.SetActive(false);
        dietOptionsPanel.SetActive(false);
        gymPlanPanel.SetActive(false);
        shopPanel.SetActive(false);
        upperBodyTextPanel.SetActive(false);
        lowerBodyTextPanel.SetActive(false);
        balancedTextPanel.SetActive(false);
        gainWeightTextPanel.SetActive(false);
        loseWeightTextPanel.SetActive(false);
        sitUpsCircle.SetActive(false);
        deadliftCylinder.SetActive(false);
    }

    void OnGymPlanClicked()
    {
        Debug.Log("Gym Plan selected");
        gymPlanPanel.SetActive(true); // Show the gym plan options panel
    }

    void OnDietPlanClicked()
    {
        Debug.Log("Diet Plan selected");
        dietOptionsPanel.SetActive(true); // Show the diet options panel
    }

    void OnShopClicked()
    {
        Debug.Log("Shop selected");
        shopPanel.SetActive(true); // Show the shop panel
    }

    void OnSeeStatsClicked()
    {
        Debug.Log("See Stats selected");
        if (capsuleStats != null)
        {
            statsText.text = capsuleStats.GetStats();
            statsPanel.SetActive(true); // Show the stats panel
        }
    }

    // Methods for gym plan options
    void OnUpperBodyClicked()
    {
        Debug.Log("Upper Body selected");
        upperBodyTextPanel.SetActive(true);
        lowerBodyTextPanel.SetActive(false);
        balancedTextPanel.SetActive(false);
    }

    void OnLowerBodyClicked()
    {
        Debug.Log("Lower Body selected");
        lowerBodyTextPanel.SetActive(true);
        upperBodyTextPanel.SetActive(false);
        balancedTextPanel.SetActive(false);
    }

    void OnBalancedClicked()
    {
        Debug.Log("Balanced selected");
        balancedTextPanel.SetActive(true);
        upperBodyTextPanel.SetActive(false);
        lowerBodyTextPanel.SetActive(false);
    }

    // Methods for diet plan options
    void OnGainWeightClicked()
    {
        Debug.Log("Gain Weight selected");
        capsuleStats.IncreaseWeight(2);
        gainWeightTextPanel.SetActive(true);
        loseWeightTextPanel.SetActive(false);
    }

    void OnLoseWeightClicked()
    {
        Debug.Log("Lose Weight selected");
        capsuleStats.DecreaseWeight(2);
        loseWeightTextPanel.SetActive(true);
        gainWeightTextPanel.SetActive(false);
    }

    // Methods for shop panel options
    void OnSitUpsButtonClicked()
    {
        Debug.Log("Sit Ups button clicked");
        sitUpsCircle.SetActive(true); // Show the sit ups circle
    }

    void OnDeadliftButtonClicked()
    {
        Debug.Log("Deadlift button clicked");
        deadliftCylinder.SetActive(true); // Show the deadlift cylinder
    }
}
