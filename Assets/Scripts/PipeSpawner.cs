using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _pipes;

    [SerializeField]
    Transform _spawnPoint;
    [SerializeField]
    Transform _destroyPoint;

    [SerializeField]
    PipeMovement _movementScript;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        for (int i = 0; i < _pipes.Count; i++)
        {
            _pipes[i].SetActive(true);
            _pipes[i].transform.position = _spawnPoint.position;
            StartCoroutine(_movementScript.Move(_pipes[i]));

            yield return new WaitForSeconds(1);
        }

        StartCoroutine(Spawn());
    }
}