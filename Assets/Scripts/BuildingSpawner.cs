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
        StartCoroutine(_movementScript.Move(_buildings[0])); // The first buildings are already spawned so they need to move first.
        StartCoroutine(Spawn());
    }

    /// <summary>
    /// Coroutine to spawn buildings and calling the Move() method, i starts from 1 because the first buildings are already spawned.
    /// </summary>
    /// <returns></returns>
    public IEnumerator Spawn()
    {
        for (int i = 1; i < _buildings.Count; i++)
        {
            _buildings[i].SetActive(true);
            _buildings[i].transform.position = _spawnPoint.position;
            StartCoroutine(_movementScript.Move(_buildings[i]));

            yield return new WaitForSeconds(28.5f);
        }

        StartCoroutine(Spawn()); // Restarting the coroutine to make it run forever.
    }
}