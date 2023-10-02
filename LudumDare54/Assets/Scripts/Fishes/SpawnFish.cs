using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    // Variables
    [SerializeField] private GameObject[] fishPrefabs;
    [SerializeField] private int spawnAmountEach;
    private float spawnInterval = 8f;

    private float xMinLeft = -45f;
    private float xMaxLeft = -15f;
    private float xMinRight = 15f;
    private float xMaxRight = 45f;
    private float xLeft = -60f;
    private float xRight = 60f;
    private float yMin = -17.5f;
    private float yMax = 17.5f;

    void Start()
    {
        InitialSpawnLeft();
        InitialSpawnRight();
        StartCoroutine(PeriodicalSpawnLeft());
        StartCoroutine(PeriodicalSpawnRight());
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
            GameObject currentFish = Instantiate(fishPrefabs[fishType], new Vector3(x, y), Quaternion.identity);
            Vector3 tempScale = currentFish.transform.localScale;
            tempScale.x *= -1;
            currentFish.transform.localScale = tempScale;
        }
    }

    private IEnumerator PeriodicalSpawnLeft()
    {
        while (true)
        {
            int fishType = Random.Range(0, fishPrefabs.Length);
            float x = xLeft;
            float y = Random.Range(yMin, yMax);
            Instantiate(fishPrefabs[fishType], new Vector3(x, y), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private IEnumerator PeriodicalSpawnRight()
    {
        while (true)
        {
            int fishType = Random.Range(0, fishPrefabs.Length);
            float x = xRight;
            float y = Random.Range(yMin, yMax);
            GameObject currentFish = Instantiate(fishPrefabs[fishType], new Vector3(x, y), Quaternion.identity);
            Vector3 tempScale = currentFish.transform.localScale;
            tempScale.x *= -1;
            currentFish.transform.localScale = tempScale;
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
