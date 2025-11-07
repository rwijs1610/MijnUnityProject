using UnityEngine;

public class CoinRespawn : MonoBehaviour
{
    public float respawnDelay = 3f;
    private Vector3 startPosition;
    public static int score = 0;
    private bool canCollect = true;  // Add flag to prevent multiple triggers

    void Start()
    {
        startPosition = transform.position;
        Debug.Log("Coin ready at: " + startPosition);
    }

    void OnTriggerEnter(Collider other)
    {
        // Only process if we can collect and it's the player
        if (!canCollect || !other.CompareTag("Player")) return;

        // Prevent multiple collections
        canCollect = false;

        // Increment score
        score++;
        Debug.Log($"Coin collected! Score: {score}");

        // Hide the coin
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Start respawn timer
        CancelInvoke();  // Cancel any pending respawns
        Invoke(nameof(Respawn), respawnDelay);
    }

    void Respawn()
    {
        // Reset position and show coin
        transform.position = startPosition;
        GetComponent<Renderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
        canCollect = true;  // Allow collection again
        Debug.Log("Coin respawned!");
    }
}
