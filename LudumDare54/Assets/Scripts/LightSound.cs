using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSound : MonoBehaviour
{
    // Variables
    private AudioSource lightSound;
    private float intervalMin = 15f;
    private float intervalMax = 30f;
    private float playDuration = 5f;

    void Start()
    {
        lightSound = GetComponent<AudioSource>();
        StartCoroutine(LightLoop());
    }

    void Update()
    {
        
    }

    private IEnumerator LightLoop()
    {
        while (true)
        {
            float interval = Random.Range(intervalMin, intervalMax);
            yield return new WaitForSeconds(interval);
            lightSound.Play();
            yield return new WaitForSeconds(playDuration);
            lightSound.Stop();
        }
    }
}
