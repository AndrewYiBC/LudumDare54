using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConclusionEnd : MonoBehaviour
{
    [SerializeField] GameObject textbox;
    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] string[] text;
    private int i;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        tmp.text = text[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // can change condition depening on where textbox is being used
        {
            if ((i + 1) < text.Length)
            {
                i += 1;
                tmp.text = text[i];
            }
            else
            {
                anim.SetBool("FinishDialogue", true);
            }
        }
    }
}
