using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewCanvas : MonoBehaviour
{
    // Constants
    // private const float DEFAULT_DEPTH = 3000f;

    // Variables
    [SerializeField] private TextMeshProUGUI xValue;
    [SerializeField] private TextMeshProUGUI yValue;
    [SerializeField] private GameObject xLimitText;
    [SerializeField] private GameObject yLimitText;
    private float xLimit = 38.95f;
    private float yLimit = 18.95f;
    private bool is_xLimit = false;
    private bool is_yLimit = false;

    void Start()
    {
        
    }

    void Update()
    {
        xValue.text = (transform.position.x * 10f).ToString("F1") + " meters";
        yValue.text = (transform.position.y * 10f).ToString("F1") + " meters";
        if (transform.position.x > xLimit || transform.position.x < -xLimit)
        {
            if (!is_xLimit)
            {
                is_xLimit = true;
                xLimitText.SetActive(true);
            }
        }
        else
        {
            if (is_xLimit)
            {
                is_xLimit = false;
                xLimitText.SetActive(false);
            }
        }
        if (transform.position.y > yLimit || transform.position.y < -yLimit)
        {
            if (!is_yLimit)
            {
                is_yLimit = true;
                yLimitText.SetActive(true);
            }
        }
        else
        {
            if (is_yLimit)
            {
                is_yLimit = false;
                yLimitText.SetActive(false);
            }
        }
    }
}
