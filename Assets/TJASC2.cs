using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TJASC2 : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Transform carController;
    void Start()
    {
        // StartCoroutine(ChangeTextAfterDelay());
    }
    public void Update()
        {
            int speed = 50;
            // speed is 5
            if (carController.position.z > 0 && carController.position.z < 4)
            {
                speed -= 10;
                myText.text = speed.ToString();
            }
            else
            {
                
                myText.text = speed.ToString();
            }
            // have text follow  z position of carController
            
            
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
