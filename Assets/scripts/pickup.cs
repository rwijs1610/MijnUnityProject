using UnityEngine;

public class pickup : MonoBehaviour
{
    private static int score = 0; // Static so it persists across all coins

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered is the player
        if (other.CompareTag("Player"))
        {
            // Increase score
            score += 1;
            
            // Log the new score
            Debug.Log("Coin collected! Score: " + score);
            
            // Destroy the coin
            Destroy(gameObject);
        }
    }
}