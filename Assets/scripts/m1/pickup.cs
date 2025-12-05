
using UnityEngine;

public class pickup : MonoBehaviour
{
    // Static so it persists across all coins
    private static int score = 0;
    private static bool gameWon = false;

    // Score needed to win (adjustable in Inspector)
    public int winScore = 20;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is the player and game not already won
        if (gameWon) return;
        if (other.CompareTag("Player"))
        {
            // Increase score
            score += 1;

            // Log the new score
            Debug.Log("Coin collected! Score: " + score);

            // Check win condition
            if (score >= winScore)
            {
                gameWon = true;
                Debug.Log("You win! Final score: " + score);
            }

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}