using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPeriscope : MonoBehaviour
{
    public GameObject player;
    Vector2 playerPos;
    Vector2 periscopePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        periscopePos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

        Debug.Log(Vector2.Distance(playerPos, periscopePos));

        if (Input.GetKeyDown(KeyCode.E) && (Vector2.Distance(playerPos, periscopePos) < 4))
        {
            SceneManager.LoadScene("UnderwaterView");
        }
    }
}
