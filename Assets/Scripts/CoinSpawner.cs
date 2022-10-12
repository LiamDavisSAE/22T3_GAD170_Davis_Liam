using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject coinPrefab;

    void Start()
    {
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
    }

    void SpawnCoin()
    {
        int xPosition = Random.Range(1, 100);
        int yPosition = Random.Range(1, 100);
        int zPosition = Random.Range(1, 100);
        Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
    }

}
