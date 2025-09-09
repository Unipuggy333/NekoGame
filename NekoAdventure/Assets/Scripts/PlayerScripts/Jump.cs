using UnityEngine;

public class Jump : MonoBehaviour
{
    // Adjust this value in the Inspector to change the jump height
    public float jumpForce = 5f; 

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Get the Rigidbody component from the GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Called every frame
    void Update()
    {
        // Check for Spacebar input and if the character is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Apply an instant upward force (impulse)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevents re-jumping mid-air
        }
    }

    // Called when the character collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the character has landed on a surface
        isGrounded = true;
    }
}