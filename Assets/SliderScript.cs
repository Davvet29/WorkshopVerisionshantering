using System;
using System.Globalization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{

    //public static event OnSliderValueChanged ;

    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text text;
    [SerializeField] private bool showDecimals;

    void Start()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void Reset()
    {
        slider = GetComponent<Slider>();
        text = GetComponentInChildren<TMP_Text>();

    }

    private void Destroy()
    {
        slider.onValueChanged.RemoveListener(HandleSliderValueChanged);
    }

    
    public void HandleSliderValueChanged(float value)
    {
        if (showDecimals)
        {
            text.SetText(value.ToString("F2"));
        }
        else
        {
            text.SetText(value.ToString("F0"));
        }
    }
}
