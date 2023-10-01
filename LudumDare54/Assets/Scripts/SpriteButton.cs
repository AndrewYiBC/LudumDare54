using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteButton : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float distance = 3f;
    Vector2 playerPos;
    Vector2 objPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        objPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

        if (Input.GetKeyDown(KeyCode.E) && (Vector2.Distance(playerPos, objPos) < distance))
        {
            Debug.Log("Clicked");
        }
    }

    void OnEnable()
    {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject obj in otherObjects)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Clicked");
    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), collision.collider);
    }
}
