using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPorthole : MonoBehaviour
{
    [SerializeField] private GameObject[] events;
    [SerializeField] private GameObject windowWall;
    [SerializeField] private GameObject journalCanvas;
    [SerializeField] private GameObject portholeCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform leftEnd;
    [SerializeField] private Transform rightEnd;
    [SerializeField] private Transform spawnPoint;
    private Rigidbody2D rb;
    private AudioSource soundEffect;
    private bool isInView = false;

    // Start is called before the first frame update
    void Start()
    {
        soundEffect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsWithinRange() && !isInView)
        {
            isInView = true;
            EnterPorthole();
            // Invoke("SwitchScene", 1.8f);
        }
    }

    private bool IsWithinRange()
    {
        return (player.transform.position.x >= leftEnd.position.x && player.transform.position.x <= rightEnd.position.x);
    }

    
    private void EnterPorthole()
    {
        player.SetActive(false);
        journalCanvas.SetActive(false);
        portholeCamera.SetActive(true);
        StartCoroutine(PortholeEvent());
    }

    /*
    private void SwitchScene()
    {
        SceneManager.LoadScene("PortholeView");
    }
    */

    // Coroutines
    private IEnumerator PortholeEvent()
    {
        yield return new WaitForSeconds(2f);
        windowWall.SetActive(true);
        int eventIndex = Random.Range(0, events.Length);
        GameObject fish = events[eventIndex];
        fish.SetActive(true);
        rb = fish.GetComponent<Rigidbody2D>();
        if (eventIndex != 0)
        {
            yield return new WaitForSeconds(15f);
        }
        else
        {
            yield return new WaitForSeconds(1.5f);
            soundEffect.Play();
            yield return new WaitForSeconds(11.5f);
            soundEffect.Stop();
            yield return new WaitForSeconds(2.0f);
        }
        rb.velocity = Vector2.zero;
        fish.transform.position = spawnPoint.position;
        fish.SetActive(false);

        windowWall.SetActive(false);
        portholeCamera.SetActive(false);
        Globals.portholeCount++;
        yield return new WaitForSeconds(2f);
        journalCanvas.SetActive(true);
        player.SetActive(true);
        isInView = false;
        yield return 0;
    }
}
