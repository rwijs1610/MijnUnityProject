
using UnityEngine;

public class BooScript : MonoBehaviour
{
    [Header("Orbit Settings")]
    public float orbitSpeed = 60f;           // degrees per second
    public float radius = 2f;                // distance from parent
    public Vector3 orbitAxis = Vector3.up;   // axis to orbit around (usually up)
    public bool lookAtParent = false;        // face the parent while orbiting
    public bool useInitialDistance = true;   // use current local position magnitude as radius

    float angle;

    void Start()
    {
        if (transform.parent == null)
        {
            Debug.LogWarning("BooScript: object has no parent to orbit around.");
        }

        if (useInitialDistance)
        {
            radius = transform.localPosition.magnitude;
        }

        // optional: set starting angle based on current local position (around Y axis)
        Vector3 local = transform.localPosition;
        angle = Mathf.Atan2(local.x, local.z) * Mathf.Rad2Deg;
    }

    void Update()
    {
        if (transform.parent == null) return;

        angle += orbitSpeed * Time.deltaTime;

        // Build rotation around the chosen axis
        Quaternion rot = Quaternion.AngleAxis(angle, orbitAxis.normalized);

        // Use forward vector as base offset (will rotate around axis)
        Vector3 offset = rot * (Vector3.forward * radius);

        // Apply offset as localPosition so it orbits around parent
        transform.localPosition = offset;

        if (lookAtParent)
        {
            transform.LookAt(transform.parent.position);
        }
    }
}
