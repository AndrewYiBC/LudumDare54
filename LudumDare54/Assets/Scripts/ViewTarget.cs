using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTarget : MonoBehaviour
{
    // Constants
    private const float A_LOW = 40f / 255f;
    private const float A_HIGH = 100f / 255f;

    // Variables
    // GameObjects
    private GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
        target = GameObject.FindWithTag("Target");
    }
}
