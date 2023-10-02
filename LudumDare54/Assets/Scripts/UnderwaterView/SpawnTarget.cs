using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    // Variables
    [SerializeField] private GameObject[] targetPrefabs;

    private float xMinLeft = -35f;
    private float xMaxLeft = -20f;
    private float xMinRight = 20f;
    private float xMaxRight = 35f;
    private float yMin = -17.5f;
    private float yMax = 17.5f;

    void Awake()
    {
        SpawnTargetRandom();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void SpawnTargetRandom()
    {
        int mode = Random.Range(0, 2);
        if (mode == 0)
        {
            SpawnTargetLeft();
        }
        else
        {
            SpawnTargetRight();
        }
    }

    private void SpawnTargetLeft()
    {
        int targetType = Random.Range(0, targetPrefabs.Length);
        float x = Random.Range(xMinLeft, xMaxLeft);
        float y = Random.Range(yMin, yMax);
        Instantiate(targetPrefabs[targetType], new Vector3(x, y), Quaternion.identity);
    }

    private void SpawnTargetRight()
    {
        int targetType = Random.Range(0, targetPrefabs.Length);
        float x = Random.Range(xMinRight, xMaxRight);
        float y = Random.Range(yMin, yMax);
        Instantiate(targetPrefabs[targetType], new Vector3(x, y), Quaternion.identity);
    }
}
