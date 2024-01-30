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
    ObjectMovement _movementScript;

    public IEnumerator Spawn()
    {
        for (int i = 0; i < _pipes.Count; i++)
        {
            int yOffset = Random.Range(-7, 10);
            Vector3 offset = new Vector3(0, yOffset, 0);

            _pipes[i].SetActive(true);
            _pipes[i].transform.position = _spawnPoint.position + offset;
            StartCoroutine(_movementScript.Move(_pipes[i]));

            yield return new WaitForSeconds(1.5f);
        }

        StartCoroutine(Spawn());
    }
}