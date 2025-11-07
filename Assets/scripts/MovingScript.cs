// ...existing code...
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingScript : MonoBehaviour
{
    public float speed = 5f;              // movement speed in m/s
    public float turnSpeed = 10f;         // rotation speed (optional)
    private Rigidbody rb;
    private Vector3 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
        // prevent the capsule from tipping over
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }

    void Update()
    {
        // Read input here
        float h = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float v = Input.GetAxisRaw("Vertical");   // W/S or Up/Down
        moveInput = new Vector3(h, 0f, v);
        if (moveInput.sqrMagnitude > 1f) moveInput.Normalize();
    }

    void FixedUpdate()
    {
        // Move using physics (preserve vertical velocity via MovePosition)
        if (moveInput.sqrMagnitude > 0.001f)
        {
            Vector3 nextPos = rb.position + moveInput * speed * Time.fixedDeltaTime;
            rb.MovePosition(nextPos);

            // Optional: rotate to face movement direction
            Quaternion targetRot = Quaternion.LookRotation(moveInput);
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRot, turnSpeed * Time.fixedDeltaTime));
        }
    }
}
// ...existing code...