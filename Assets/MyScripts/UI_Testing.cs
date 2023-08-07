using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using System;


public class UI_Testing : MonoBehaviour
{

   public UI_InputWindow inputWindow;
   public Transform submitBtn;
    

    private void Start()
    {
        submitBtn.GetComponent<Button_UI>().ClickFunc = () =>
        {
            inputWindow.Show("qwerty", () =>
            { }, (string inputText) => { });
        };
    }
}
