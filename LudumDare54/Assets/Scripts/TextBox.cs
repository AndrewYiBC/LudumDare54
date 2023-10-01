using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBox : MonoBehaviour
{
    public GameObject textbox;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isActive = textbox.gameObject.activeSelf;
        if(Input.GetKeyDown(KeyCode.E)) // can change condition depening on where textbox is being used
        {
            textbox.gameObject.SetActive(!isActive);
        }
    }
}
