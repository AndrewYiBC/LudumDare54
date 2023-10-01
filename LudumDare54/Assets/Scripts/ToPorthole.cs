using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPorthole : MonoBehaviour
{
    public GameObject PortholeCamera;
    public GameObject PlayerSprite;
    private bool viewing = false;
    Vector2 playerPos;
    Vector2 portholePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector2(PlayerSprite.transform.position.x, PlayerSprite.transform.position.y);
        portholePos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

        if (Input.GetKeyDown(KeyCode.E) && (viewing || (Vector2.Distance(playerPos, portholePos) < 3) ))
        {
            EnterPorthole();
            Invoke("SwitchScene", 1.8f);
        }
    }


    private void EnterPorthole()
    {
        PortholeCamera.SetActive(true);
        PlayerSprite.SetActive(false);
        viewing = true;
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene("PortholeView");
    }
}
