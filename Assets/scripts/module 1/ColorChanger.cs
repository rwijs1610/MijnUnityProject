using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private bool playerOnPlatform = false;
    private Renderer platformRenderer;
    private Color currentColor;

    void Start()
    {
        platformRenderer = GetComponent<Renderer>();
        if (platformRenderer == null)
        {
            Debug.LogError("ColorChanger needs a Renderer component!");
        }
        currentColor = platformRenderer.material.color;
    }

    void Update()
    {
        if (!playerOnPlatform) return;

        // Check for RGB key presses
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeColor(Color.red, "Red");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeColor(Color.green, "Green");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeColor(Color.blue, "Blue");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnPlatform = true;
            Debug.Log("Player entered platform - Press R/G/B to change colors!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnPlatform = false;
            Debug.Log("Player left platform");
        }
    }

    private void ChangeColor(Color newColor, string colorName)
    {
        currentColor = newColor;
        platformRenderer.material.color = currentColor;
        Debug.Log($"Platform color changed to {colorName}");
    }
}