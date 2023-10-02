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
        int count1 = Globals.portholeCount;
        if (count1 > Globals.portholeRequired)
        {
            count1 = Globals.portholeRequired;
        }
        TaskPorthole.text = "(" + count1.ToString() + "/" + Globals.portholeRequired.ToString() + ")";
        int count2 = Globals.periscopeCount;
        if (count2 > Globals.periscopeRequired)
        {
            count2 = Globals.periscopeRequired;
        }
        TaskPeriscope.text = "(" + count2.ToString() + "/" + Globals.periscopeRequired.ToString() + ")";
        if (Globals.pipeFixed)
        {
            TaskPipes.text = "Done!";
        }
        if (Globals.wallFixed)
        {
            TaskWall.text = "Done!";
        }
        if (Globals.antennaFixed)
        {
            TaskAntenna.text = "Done!";
        }
        PartsCount.text = Globals.itemCount.ToString();
    }
}
