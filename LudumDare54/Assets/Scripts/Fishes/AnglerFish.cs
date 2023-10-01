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
    private float xMin = -60f;
    private float xMax = 60f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * speed;
    }

    void Update()
    {
        if (isOutOfRange())
        {
            rb.velocity = Vector3.zero;
            // gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private bool isOutOfRange()
    {
        return (transform.position.x < xMin || transform.position.x > xMax);
    }
}
