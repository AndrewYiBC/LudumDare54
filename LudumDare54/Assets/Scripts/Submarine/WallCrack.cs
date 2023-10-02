using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCrack : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform leftEnd;
    [SerializeField] private Transform rightEnd;

    [SerializeField] GameObject Wall;
    private bool isFixed = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (!isFixed && Input.GetKeyDown(KeyCode.E) && IsWithinRange() && Globals.itemCount > 0)
        {
            isFixed = true;
            Globals.itemCount--;
            Globals.wallFixed = true;
            gameObject.SetActive(false);
            Wall.SetActive(true);
        }
    }

    private bool IsWithinRange()
    {
        return (player.transform.position.x >= leftEnd.position.x && player.transform.position.x <= rightEnd.position.x);
    }
}
