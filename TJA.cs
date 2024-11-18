using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TJA : MonoBehaviour
{
public TextMeshProUGUI myText;

public void buttonPressed() {
     myText.text = "TJA unable to start: cannot recognize highway";
}
}
