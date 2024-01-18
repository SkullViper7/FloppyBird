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

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < _pipes.Count; i++)
        {
            _pipes[i].transform.position = _spawnPoint.position;
            _pipes[i].SetActive(true);
            StartCoroutine(Move(_pipes[i]));

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator Move(GameObject pipe)
    {
        pipe.transform.position = Vector3.MoveTowards(transform.position, _destroyPoint.position, 1);

        yield return null;
    }
}