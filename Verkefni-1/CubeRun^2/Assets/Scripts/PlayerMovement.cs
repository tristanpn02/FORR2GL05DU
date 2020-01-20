using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference to RigidBody component
    public Rigidbody rb;

    // Force variables
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Marked as "FixedUpdate" since physics is being manipulated
    void FixedUpdate() {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
