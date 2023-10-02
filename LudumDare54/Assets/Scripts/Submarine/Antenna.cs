using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : MonoBehaviour
{
    [SerializeField] GameObject FixedAntenna;
    private bool isFixed = false;

    void Start()
    {

    }

    void Update()
    {
        if (!isFixed)
        {
            if (Globals.pipeFixed)
            {
                isFixed = true;
                gameObject.SetActive(false);
                FixedAntenna.SetActive(true);
            }
        }
    }
}
