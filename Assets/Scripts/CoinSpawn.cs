using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
        
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
            yield return new WaitForSeconds(Random.Range(0.5f, 1.0f));
            GameObject newCoin = Instantiate(coin);

            float spawnX = 13.0f;
            float spawnY = Random.Range(-0.5f,0.0f);
            Vector2 position = new Vector2(spawnX, spawnY);
            newCoin.name = "Coin";
            newCoin.transform.position = position;
        }
    }
}
