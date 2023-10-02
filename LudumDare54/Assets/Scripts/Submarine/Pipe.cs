using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform leftEnd;
    [SerializeField] private Transform rightEnd;

    [SerializeField] GameObject FixedPipe;
    private bool isFixed = false;

    void Start()
    {
        if (Globals.pipeFixed)
        {
            gameObject.SetActive(false);
            FixedPipe.SetActive(true);
        }
    }

    void Update()
    {
        if (!Globals.pipeFixed)
        {
            if (!isFixed && Input.GetKeyDown(KeyCode.E) && IsWithinRange() && Globals.itemCount > 0)
            {
                isFixed = true;
                Globals.itemCount--;
                Globals.pipeFixed = true;
                gameObject.SetActive(false);
                FixedPipe.SetActive(true);
            }
        }
    }

    private bool IsWithinRange()
    {
        return (player.transform.position.x >= leftEnd.position.x && player.transform.position.x <= rightEnd.position.x);
    }
}
