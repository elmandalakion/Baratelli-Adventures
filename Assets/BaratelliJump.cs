using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BaratelliJump : MonoBehaviour
{
    public float jumpForce = 7f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevent double jumping
            Debug.Log("Boing! 🐸💨");
        }

                Debug.Log("IsGrounded: " + isGrounded);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if we landed on something tagged as Ground or Lily
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Lily"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // When we stop touching the ground/lily, we're airborne
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Lily"))
        {
            isGrounded = false;
        }
    }
}

