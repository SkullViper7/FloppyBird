using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.AddScore();
    }
}