using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int health = 3; // Starting health
    public Text healthText; // Reference to UI Text component

    void Start()
    {
        UpdateHealthDisplay();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Decrease health
            health--;
            UpdateHealthDisplay();
            Debug.Log($"Hit by enemy! Health remaining: {health}");

            // Reload current scene
            string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);

            if (health <= 0)
            {
                Debug.Log("Game Over!");
                health = 3;
                UpdateHealthDisplay();
            }
        }
    }

    void UpdateHealthDisplay()
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {health}";
        }
    }
}