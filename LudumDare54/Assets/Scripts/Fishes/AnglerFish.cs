using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnglerFish : MonoBehaviour
{
    // Variables
    // Components
    private Rigidbody2D rb;
    // Move
    [SerializeField] private float speed;
    private float xMin = -75f;
    private float xMax = 75f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * speed, 0f);
    }

    void Update()
    {
        if (isOutOfRange())
        {
            rb.velocity = Vector2.zero;
            // gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private bool isOutOfRange()
    {
        return (transform.position.x < xMin || transform.position.x > xMax);
    }
}
