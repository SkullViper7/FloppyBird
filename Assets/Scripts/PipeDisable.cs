using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDisable : MonoBehaviour
{
    [SerializeField]
    PipeSpawner _spawnScript;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
    }
}