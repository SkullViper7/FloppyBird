using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _buildings;

    [SerializeField]
    Transform _spawnPoint;

    [SerializeField]
    ObjectMovement _movementScript;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        for (int i = 0; i < _buildings.Count; i++)
        {
            _buildings[i].SetActive(true);
            _buildings[i].transform.position = _spawnPoint.position;
            StartCoroutine(_movementScript.Move(_buildings[i]));

            yield return new WaitForSeconds(9.6f);
        }

        StartCoroutine(Spawn());
    }
}