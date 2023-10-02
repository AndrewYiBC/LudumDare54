using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JournalUpdate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TaskPorthole;
    [SerializeField] private TextMeshProUGUI TaskPeriscope;
    [SerializeField] private TextMeshProUGUI TaskPipes;
    [SerializeField] private TextMeshProUGUI TaskWall;
    [SerializeField] private TextMeshProUGUI TaskAntenna;
    [SerializeField] private TextMeshProUGUI PartsCount;

    void Start()
    {
        
    }

    void Update()
    {
        TaskPorthole.text = Globals.portholeCount.ToString();
        TaskPeriscope.text = Globals.periscopeCount.ToString();
        if (Globals.pipeFixed)
        {
            TaskPipes.text = "Done!";
        }
        if (Globals.wallFixed)
        {
            TaskWall.text = "Done!";
        }
        if (Globals.pipeFixed)
        {
            TaskAntenna.text = "Done!";
        }
        PartsCount.text = Globals.itemCount.ToString();
    }
}
