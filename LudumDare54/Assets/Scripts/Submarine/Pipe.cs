using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] GameObject FixedPipe;
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
                FixedPipe.SetActive(true);
            }
        }
    }
}
