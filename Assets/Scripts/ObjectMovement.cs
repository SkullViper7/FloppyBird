using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField]
    float _speed;

    public IEnumerator Move(GameObject @object)
    {
        @object.GetComponent<Rigidbody>().velocity = Vector3.left * _speed;

        yield return null;
    }
}