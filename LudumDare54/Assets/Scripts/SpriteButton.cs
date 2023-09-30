using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject obj in otherObjects)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), collision.collider);
    }
}
