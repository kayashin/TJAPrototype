using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => _sliderText.text = v.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
