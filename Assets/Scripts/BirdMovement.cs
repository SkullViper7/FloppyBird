using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    float _jumpForce;

    [SerializeField]
    float _rotationSpeed;

    [SerializeField]
    PipeSpawner _spawnerScript;

    Rigidbody rb;

    bool _hasGameStarted;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 180, -rb.velocity.y * _rotationSpeed);
    }

    public void OnJump()
    {
        if (!_hasGameStarted)
        {
            StartCoroutine(_spawnerScript.Spawn());
            _hasGameStarted = true;
        }

        rb.useGravity = true;
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
}