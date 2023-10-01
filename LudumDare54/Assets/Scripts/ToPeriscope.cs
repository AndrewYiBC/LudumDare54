using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPeriscope : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform leftEnd;
    [SerializeField] private Transform rightEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsWithinRange())
        {
            SceneManager.LoadScene("UnderwaterView");
        }
    }

    private bool IsWithinRange()
    {
        return (player.position.x >= leftEnd.position.x && player.position.x <= rightEnd.position.x);
    }
}
