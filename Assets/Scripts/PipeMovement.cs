using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField]
    float _speed;

    public IEnumerator Move(GameObject pipe)
    {
        pipe.GetComponent<Rigidbody>().velocity = Vector3.left * _speed;

        yield return null;
    }
}