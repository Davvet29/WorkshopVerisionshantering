using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 boost;
    private Rigidbody rb;
    private float x;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("entered trigger");
            boost = Vector3.left * 60;
            rb.AddForce(boost, ForceMode.Impulse);
        }
    }
}
