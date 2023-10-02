using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform leftEnd;
    [SerializeField] private Transform rightEnd;

    [SerializeField] GameObject FixedAntenna;
    private bool isFixed = false;

    void Start()
    {
        if (Globals.antennaFixed)
        {
            gameObject.SetActive(false);
            FixedAntenna.SetActive(true);
        }
    }

    void Update()
    {
        if (!Globals.antennaFixed)
        {
            if (!isFixed && Input.GetKeyDown(KeyCode.E) && IsWithinRange() && Globals.itemCount > 0)
            {
                isFixed = true;
                Globals.itemCount--;
                Globals.antennaFixed = true;
                gameObject.SetActive(false);
                FixedAntenna.SetActive(true);
            }
        }
    }

    private bool IsWithinRange()
    {
        return (player.transform.position.x >= leftEnd.position.x && player.transform.position.x <= rightEnd.position.x);
    }
}
