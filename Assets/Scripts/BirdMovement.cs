using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    float _jumpForce;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnJump()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
}