using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTarget : MonoBehaviour
{
    // Variables
    // GameObjects
    private GameObject target;
    [SerializeField] private GameObject arrow0;
    [SerializeField] private GameObject arrow1;
    [SerializeField] private GameObject arrow2;
    [SerializeField] private GameObject arrow3;

    // Components
    private SpriteRenderer[] sr = new SpriteRenderer[4];

    // Colors
    private Color greenHigh = new Color(0f, 0.5f, 0f, 100f / 255f);
    private Color greenLow = new Color(0f, 0.5f, 0f, 40f / 255f);

    // Times
    private float tHigh = 0.5f;
    private float[] tLow = { 0.5f, 1.5f, 2.5f };

    // Distances
    private float dFar = 25f;
    private float dMid = 15f;
    private float dClose = 5f;

    // Distance status
    private int dStatus = 3;

    // Target
    private float distance;
    private Coroutine currentCoroutine = null;

    void Start()
    {
        sr[0] = arrow0.GetComponent<SpriteRenderer>();
        sr[1] = arrow1.GetComponent<SpriteRenderer>();
        sr[2] = arrow2.GetComponent<SpriteRenderer>();
        sr[3] = arrow3.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        target = GameObject.FindWithTag("Target");
        if (target != null)
        {
            distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance <= dClose && dStatus != 0)
            {
                dStatus = 0;
                if (currentCoroutine != null)
                {
                    StopCoroutine(currentCoroutine);
                    ResetColors();
                }
                currentCoroutine = StartCoroutine(Flash(0));
            }
            else if (distance > dClose && distance <= dMid && dStatus != 1)
            {
                dStatus = 1;
                if (currentCoroutine != null)
                {
                    StopCoroutine(currentCoroutine);
                    ResetColors();
                }
                currentCoroutine = StartCoroutine(Flash(1));
            }
            else if (distance > dMid && distance <= dFar && dStatus != 2)
            {
                dStatus = 2;
                if (currentCoroutine != null)
                {
                    StopCoroutine(currentCoroutine);
                    ResetColors();
                }
                currentCoroutine = StartCoroutine(Flash(2));
            }
            else if (distance > dFar)
            {
                dStatus = 3;
                if (currentCoroutine != null)
                {
                    StopCoroutine(currentCoroutine);
                    ResetColors();
                }
            }
        }
    }

    // Helper Functions
    private int GetSrIndex()
    {
        float xDiff = target.transform.position.x - transform.position.x;
        float yDiff = target.transform.position.y - transform.position.y;
        if (xDiff >= 0 && yDiff >= 0)
        {
            return 0;
        }
        else if (xDiff < 0 && yDiff >= 0)
        {
            return 1;
        }
        else if (xDiff < 0 && yDiff <= 0)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }

    private void ResetColors()
    {
        for (int i = 0; i < 4; i++)
        {
            sr[i].color = greenLow;
        }
    }

    // Coroutines
    private IEnumerator Flash(int frequency)
    {
        while(true)
        {
            int i = GetSrIndex();
            sr[i].color = greenHigh;
            yield return new WaitForSeconds(tHigh);
            sr[i].color = greenLow;
            yield return new WaitForSeconds(tLow[frequency]);
        }
    }
}
