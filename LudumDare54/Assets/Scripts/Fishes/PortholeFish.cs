using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortholeFish : MonoBehaviour
{
    // Variables
    // Components
    private Rigidbody2D rb;
    // Move
    [SerializeField] private float speed;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0f);
    }
}
