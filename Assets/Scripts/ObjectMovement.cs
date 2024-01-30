using System.Collections;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField]
    float _speed;

    /// <summary>
    /// Method to move object from right to left.
    /// </summary>
    /// <param name="object"></param>
    /// <returns></returns>
    public IEnumerator Move(GameObject @object)
    {
        @object.GetComponent<Rigidbody>().velocity = Vector3.left * _speed;

        yield return null;
    }
}