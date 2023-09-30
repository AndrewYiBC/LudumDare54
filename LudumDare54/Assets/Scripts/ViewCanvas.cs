using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewCanvas : MonoBehaviour
{
    // Constants
    private const float DEFAULT_DEPTH = 3000f;

    // Variables
    [SerializeField] private TextMeshProUGUI depth;

    void Start()
    {
        
    }

    void Update()
    {
        depth.text = (DEFAULT_DEPTH - transform.position.y * 10f).ToString("F1") + " meters";
    }
}
