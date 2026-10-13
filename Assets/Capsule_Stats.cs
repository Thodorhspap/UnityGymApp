using UnityEngine;

public class CapsuleStats : MonoBehaviour
{
    public float arms = 10f;
    public float core = 10f;
    public float legs = 10f;
    public float chest = 10f;
    public float back = 10f;
    public float weight = 80f;

    void Start()
    {
        // Initialize stats if necessary
        Debug.Log("Initial Stats - Arms: " + arms + ", Core: " + core + ", Legs: " + legs + ", Chest: " + chest + ", Back: " + back + ", Weight: " + weight);
    }

    // Method to increase arms
    public void IncreaseArms(float amount)
    {
        arms += amount;
        Debug.Log("Arms increased to: " + arms);
    }

    // Method to increase core
    public void IncreaseCore(float amount)
    {
        core += amount;
        Debug.Log("Core increased to: " + core);
    }

    // Method to increase legs
    public void IncreaseLegs(float amount)
    {
        legs += amount;
        Debug.Log("Legs increased to: " + legs);
    }

    // Method to increase chest
    public void IncreaseChest(float amount)
    {
        chest += amount;
        Debug.Log("Chest increased to: " + chest);
    }

    // Method to increase back
    public void IncreaseBack(float amount)
    {
        back += amount;
        Debug.Log("Back increased to: " + back);
    }

    // Method to decrease weight
    public void DecreaseWeight(float amount)
    {
        weight -= amount;
        Debug.Log("Weight decreased to: " + weight);
    }

    // Method to increase weight
    public void IncreaseWeight(float amount)
    {
        weight += amount;
        Debug.Log("Weight increased to: " + weight);
    }

    public string GetStats()
    {
        return $"Arms: {arms}\nCore: {core}\nLegs: {legs}\nChest: {chest}\nBack: {back}\nWeight: {weight}";
    }
    public float GetWeight()
    {
        return weight;
    }
}