using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPorthole : MonoBehaviour
{
    [SerializeField] private GameObject portholeCamera;
    [SerializeField] private GameObject player;
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
            EnterPorthole();
            Invoke("SwitchScene", 1.8f);
        }
    }

    private bool IsWithinRange()
    {
        return (player.transform.position.x >= leftEnd.position.x && player.transform.position.x <= rightEnd.position.x);
    }

    private void EnterPorthole()
    {
        portholeCamera.SetActive(true);
        player.SetActive(false);
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene("PortholeView");
    }
}
