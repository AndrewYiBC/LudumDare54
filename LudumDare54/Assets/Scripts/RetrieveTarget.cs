using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveTarget : MonoBehaviour
{
    // Variables
    // GameObjects
    private GameObject target = null;
    [SerializeField] private GameObject grapplePoint;
    [SerializeField] private GameObject grapple;

    // Components
    private Rigidbody2D rb;

    // Grappling Hook
    private float grapplingDuration = 2f;
    private int moveTimes = 20;

    // Target
    [SerializeField] private LayerMask targetLayer;
    private float checkRadius = 0.5f;
    private bool isRetrieved = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("Target");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (CanRetriveTarget())
            {
                if (!isRetrieved)
                {
                    isRetrieved = true;
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    StartCoroutine(GrapplingAnimation());
                }
                
            }
        }
    }

    // Helper Functins
    private bool CanRetriveTarget()
    {
        return (target != null && Vector3.Distance(target.transform.position, transform.position) < checkRadius);
    }

    // Coroutines
    private IEnumerator GrapplingAnimation()
    {
        float deltaTime = grapplingDuration / moveTimes;
        Vector3 deltaMove = new Vector3(0f, (6f / moveTimes), 0f);

        for (int i = 0; i < moveTimes; i++)
        {
            grapple.transform.position = grapple.transform.position + deltaMove;
            yield return new WaitForSeconds(deltaTime);
        }

        yield return new WaitForSeconds(1f);
        target.SetActive(false);
        grapple.SetActive(false);

        yield return 0;
    }
}
