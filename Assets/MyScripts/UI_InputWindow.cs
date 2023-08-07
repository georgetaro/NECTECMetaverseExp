using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using TMPro;
using System;

public class UI_InputWindow : MonoBehaviour
{

    private Button_UI okBtn;
    private Button_UI cancelBtn;
    private TextMeshProUGUI titleText;
    private TMP_InputField inputField;

    private void Awake()
    {
        okBtn = transform.Find("OKBtn").GetComponent<Button_UI>();
        cancelBtn = transform.Find("cancelBtn").GetComponent<Button_UI>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();

        Hide();


    }
    public void Show(string inputString, Action  onCancel, Action<string> onOk )
    {
        gameObject.SetActive(true);
        
       
        inputField.text = inputString;

        okBtn.ClickFunc = () =>
        {
            Hide();
            onOk(inputField.text);

        };

        cancelBtn.ClickFunc = () =>
        {
            Hide();
            onCancel();
        };
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
