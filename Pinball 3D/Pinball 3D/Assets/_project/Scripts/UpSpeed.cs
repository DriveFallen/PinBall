using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSpeed : MonoBehaviour
{
    [SerializeField] private float upSpeed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(rb.velocity.normalized * upSpeed, ForceMode.Impulse);
    }
}
