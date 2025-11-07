using UnityEngine;

public class BounceCollision : MonoBehaviour
{
    // ...existing code...
    public string message = "wall triggered";
    public bool onlyPlayer = true;
    public string playerTag = "Player";
    public float bounceForce = 60f; // used as velocity multiplier on reflect
    Renderer ren;
    // ...existing code...

    // Preferred: physical bounce when the wall is NOT a trigger
    void OnCollisionEnter(Collision collision)
    {
        if (onlyPlayer && !collision.gameObject.CompareTag(playerTag)) return;

        if (TryGetComponent<Renderer>(out ren))
            ren.material.color = Color.yellow;

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // use the contact normal when available for an accurate reflection
            Vector3 normal = collision.contacts.Length > 0 ? collision.contacts[0].normal : (rb.transform.position - transform.position).normalized;
            Vector3 reflected = Vector3.Reflect(rb.linearVelocity, normal);
            rb.linearVelocity = reflected * bounceForce;
        }

        Debug.Log($"{message} - collided by: {collision.gameObject.name} (tag: {collision.gameObject.tag})");
    }
}