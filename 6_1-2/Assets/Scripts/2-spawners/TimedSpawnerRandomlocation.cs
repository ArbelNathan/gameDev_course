using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawnerRandomlocation: MonoBehaviour {
    [SerializeField] GameObject prefabToSpawn;

    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;

    // Start is called before the first frame update
    void Start() {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            var shieldRadius = prefabToSpawn.GetComponent<CircleCollider2D>().radius;
            var screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                Random.Range(-screenBounds.x + shieldRadius, +screenBounds.x - shieldRadius),
                Random.Range(-screenBounds.y + shieldRadius, +screenBounds.y - shieldRadius),
                0);
            GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, Quaternion.identity);
        }
    }
}
