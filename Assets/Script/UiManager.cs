using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

public InteractabelObject activeIO;
public Text Dialogfenster;

    
    
    public void DisplayText()
    {
        Dialogfenster.text = activeIO.inspectText;
    }

    public void Exit()
    {
        Dialogfenster.text = " ";
    }

    public void CollectItem()
    {
        Debug.Log("CollectItem FKT ist aufgerufen");
        activeIO.img.sprite = activeIO.spriteObject;
    }
}
