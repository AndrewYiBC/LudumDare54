using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBox : MonoBehaviour
{
    [SerializeField] GameObject textbox;
    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] string[] text;
    private int i;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        tmp.text = text[0];
    }

    // Update is called once per frame
    void Update()
    {
        isActive = textbox.gameObject.activeSelf;
        if(Input.GetKeyDown(KeyCode.E)) // can change condition depening on where textbox is being used
        {
            if(!isActive)
            {
                textbox.gameObject.SetActive(true);
                isActive = true;
            }
            else if ((i + 1) < text.Length)
            {
                i += 1;
                tmp.text = text[i];
            }
            else
            {
                i = 0;
                tmp.text = text[0];
                textbox.gameObject.SetActive(false);
                isActive = false;
            }
        }
    }
}
