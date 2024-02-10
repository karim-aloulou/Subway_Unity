using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab du coin � g�n�rer
    public int numberOfCoins = 10; // Nombre de coins � g�n�rer
    public float minX = -5f; // Limite X minimale pour la g�n�ration de coins
    public float maxX = 5f;
    public float y = 0.5f; 

    void Start()
    {
        GenerateCoins();
    }

    void GenerateCoins()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, y, 0f);

            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
