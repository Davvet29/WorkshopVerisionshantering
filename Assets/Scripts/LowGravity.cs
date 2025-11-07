using UnityEngine;

public class LowGravity : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Physics.gravity * rb.mass);
    }
}
