using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViperFish : MonoBehaviour
{
    // Variables
    // Components
    private Rigidbody2D rb;
    // Move
    private float speed;
    private float xMin = -75f;
    private float xMax = 75f;
    // Scale
    private float minScale = 0.8f;
    private float maxScale = 1.2f;

    void Start()
    {
        Vector3 currentScale = transform.localScale;
        float scaleChange = Random.Range(minScale, maxScale);
        currentScale.x = currentScale.x * scaleChange;
        currentScale.y = currentScale.y * scaleChange;
        transform.localScale = currentScale;
        speed = Random.Range(1.8f, 2.5f);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Mathf.Sign(transform.localScale.x) * speed, 0f);
    }

    void Update()
    {
        if (isOutOfRange())
        {
            rb.velocity = Vector2.zero;
            Destroy(gameObject);
        }
    }

    private bool isOutOfRange()
    {
        return (transform.position.x < xMin || transform.position.x > xMax);
    }
}
