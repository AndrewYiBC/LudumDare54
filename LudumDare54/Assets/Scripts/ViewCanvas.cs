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

    void Start()
    {
        
    }

    void Update()
    {
        xValue.text = (transform.position.x * 10f).ToString("F1") + " meters";
        yValue.text = (transform.position.y * 10f).ToString("F1") + " meters";
    }
}
