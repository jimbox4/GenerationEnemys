using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Object _objectToSpawn;
    [SerializeField, Min(0)] private float _delay;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        if (_spawnPoints == null)
            return;

        StartCoroutine(SpawnObject(_delay));
    }

    private IEnumerator SpawnObject(float delay)
    {
        var wait = new WaitForSeconds(delay);
        int spawnPointIndex;

        while (enabled)
        {
            spawnPointIndex = Random.Range(0, _spawnPoints.Length);
            Instantiate(_objectToSpawn, _spawnPoints[spawnPointIndex].position, _spawnPoints[spawnPointIndex].rotation);

            yield return wait;
        }
    }
}
