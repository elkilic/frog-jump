using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour
{
    public Platform platformPrefab;

    public int platformCount = 300;
     
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; 1 < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
