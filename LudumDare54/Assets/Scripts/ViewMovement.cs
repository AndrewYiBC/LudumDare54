using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMovement : MonoBehaviour
{
    // Variables
    // Components
    private Rigidbody2D rb;

    // Movement
    [SerializeField] float moveSpeed;
    private float moveInputHorizontal = 0f;
    private float moveInputVertical = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInputHorizontal = Input.GetAxisRaw("Horizontal");
        moveInputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInputHorizontal * moveSpeed, moveInputVertical * moveSpeed);
    }
}
