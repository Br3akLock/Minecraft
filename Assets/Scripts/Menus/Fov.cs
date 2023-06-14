using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fov : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    private void Start()
    {
        _slider.onValueChanged.AddListener(OnFOVChanged);
    }

    private void OnFOVChanged(float value)
    {
        int intValue = Mathf.RoundToInt(value);

        if (intValue == 70)
        {
            _sliderText.text = "Campo de visão: Padrão"; //a
        }
        else if (intValue == 110)
        {
            _sliderText.text = "Campo de visão: Máximo";
        }
        else
        {
            _sliderText.text = "Campo de visão: " + intValue.ToString();
        }
    }
}
