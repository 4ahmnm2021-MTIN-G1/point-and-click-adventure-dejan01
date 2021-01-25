using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanangeButtonColor : MonoBehaviour
{
    public Color c;
    public Button button;
    public GameObject display;

    public void ButtonColorRed(){
        ColorBlock cb = button.colors;
        cb.normalColor = c;
        cb.highlightedColor = c;
        cb.pressedColor = c;
        button.colors = cb;
    }

   
}
