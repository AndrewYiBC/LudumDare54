using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialFishSpawn : MonoBehaviour
{
    // Variables
    [SerializeField] private GameObject[] fishPrefabs;
    [SerializeField] private int spawnAmountEach;
    private float xMinLeft = -35f;
    private float xMaxLeft = -15f;
    private float xMinRight = 15f;
    private float xMaxRight = 35f;

    private float yMin = -15f;
    private float yMax = 15f;

    void Start()
    {
        InitialSpawnLeft();
        InitialSpawnRight();
    }

    void Update()
    {
        
    }

    // Fish Spawn Functions
    private void InitialSpawnLeft()
    {
        for (int i = 0; i < spawnAmountEach; i++)
        {
            int fishType = Random.Range(0, fishPrefabs.Length);
            float x = Random.Range(xMinLeft, xMaxLeft);
            float y = Random.Range(yMin, yMax);
            Instantiate(fishPrefabs[fishType], new Vector3(x, y), Quaternion.identity);
        }
    }

    private void InitialSpawnRight()
    {
        for (int i = 0; i < spawnAmountEach; i++)
        {
            int fishType = Random.Range(0, fishPrefabs.Length);
            float x = Random.Range(xMinRight, xMaxRight);
            float y = Random.Range(yMin, yMax);
            Instantiate(fishPrefabs[fishType], new Vector3(x, y), Quaternion.identity);
        }
    }
}
