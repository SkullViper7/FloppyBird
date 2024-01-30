using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _pipes;

    [SerializeField]
    Transform _spawnPoint;

    [SerializeField]
    ObjectMovement _movementScript;

    /// <summary>
    /// Spawning pipes with an offset on random heights on a certain frequency.
    /// </summary>
    /// <returns></returns>
    public IEnumerator Spawn()
    {
        for (int i = 0; i < _pipes.Count; i++)
        {
            int yOffset = Random.Range(-7, 10);
            Vector3 offset = new Vector3(0, yOffset, 0);

            _pipes[i].SetActive(true);
            _pipes[i].transform.position = _spawnPoint.position + offset;
            StartCoroutine(_movementScript.Move(_pipes[i])); // Calling the move method to apply movement to the pipes when they spawn.

            yield return new WaitForSeconds(1.5f);
        }

        StartCoroutine(Spawn()); // Restart the coroutine until the game is over.
    }
}