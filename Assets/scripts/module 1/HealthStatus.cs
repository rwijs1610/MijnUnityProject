using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    public int health = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Current Health: " + health);
        if (health > 80)
        {
            Debug.Log("Excellent health!");
        }
        else if (health > 50)
        {
            Debug.Log("Good health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low health!");
        }
        else
        {
            Debug.Log("Critical: Very low health!");
        }   

        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            health += 10;
        }
    }
}
