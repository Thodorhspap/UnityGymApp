using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text messageText; // Reference to the TextMeshPro text component

    public void ShowMessage(string message)
    {
        messageText.text = message;
        messageText.gameObject.SetActive(true);
        Invoke("HideMessage", 3f); // Hide the message after 3 seconds
    }

    void HideMessage()
    {
        messageText.gameObject.SetActive(false);
    }
}