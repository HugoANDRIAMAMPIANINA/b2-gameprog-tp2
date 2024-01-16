using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;
        
    private IEnumerator _coroutine;
    void Start()
    {
        _coroutine = Spawn();
        StartCoroutine(_coroutine);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.6f, 2.0f));
            GameObject newObstacle = Instantiate(obstacle);

            float spawnX = 13.0f;
            float spawnY = -3.7f;
            Vector2 position = new Vector2(spawnX, spawnY);
            newObstacle.name = "Obstacle";
            newObstacle.transform.position = position;
        }
    }
}
