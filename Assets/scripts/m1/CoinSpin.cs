using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float spinSpeed = 100f;    // Degrees per second

    void Update()
    {
        // Rotate the coin around Y axis only
        transform.Rotate(1f, spinSpeed * Time.deltaTime, 0f);
    }
}