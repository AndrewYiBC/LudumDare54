using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempGauge : MonoBehaviour
{
    public Image thermometer;
    public float decreaseTime = 30.0f;
    public float increaseTime = 15.0f;


    // Start is called before the
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TempLowers();
    }

    private void TempLowers()
    {
        thermometer.fillAmount -= 1.0f / decreaseTime * Time.deltaTime;
    }

    private void TempRaises()
    {
        thermometer.fillAmount += 1.0f / increaseTime * Time.deltaTime;
    }
}
