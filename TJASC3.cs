using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TJASC3 : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Transform carController;
    void Start()
    {
        // StartCoroutine(ChangeTextAfterDelay());
    }
    public void Update()
        {
            if (carController.position.z < 1)
            {
                myText.text = "TJA Engaged";
            }
            else
            {
                myText.text = "TJA Disengaged";
            }
        }

//     public IEnumerator ChangeTextAfterDelay()
//     {
//         while (true)
//         {
//         yield return new WaitForSeconds(3);
//         myText.text = "TJA Disengaged";
//         yield return new WaitForSeconds(3);
//         myText.text = "TJA Engaged";
//         }
    
// }
}
