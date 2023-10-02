using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCrack : MonoBehaviour
{
    [SerializeField] GameObject Wall;
    private bool isFixed = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (!isFixed)
        {
            if (Globals.wallFixed)
            {
                isFixed = true;
                gameObject.SetActive(false);
                Wall.SetActive(true);
            }
        }
    }
}
