using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TJAToggle : MonoBehaviour
{
    public TextMeshProUGUI myText;
    bool toggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggle = true;
    }

    public void buttonPressed()
    {
        if (toggle)
        {
            myText.text = "TJA Disengaged";
            toggle = false;
        }
        else
        {
            myText.text = "TJA Engaged";
            toggle = true;
        }
    }


}
