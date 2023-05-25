using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] GameObject ui_window;
    [SerializeField] Text textField;

    public void ToggleUI(bool value)
    {
        ui_window.SetActive(value);
    }    
    public void ShowText(string text)
    {
        ToggleUI(true);
        textField.text = text;
    }    
}
