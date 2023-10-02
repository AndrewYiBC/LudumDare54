using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    private float inputX;
    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
        anim.SetFloat("VelocityX", Mathf.Abs(inputX));
        if ((isFacingRight && inputX < 0) || (!isFacingRight && inputX > 0))
        {
            Flip();
        }
    }

    void OnEnable()
    {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("Activity");

        foreach (GameObject obj in otherObjects)
        {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 tempScale = transform.localScale;
        tempScale.x *= -1;
        transform.localScale = tempScale;
    }
}
