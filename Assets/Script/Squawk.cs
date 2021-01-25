using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squawk : MonoBehaviour
{
    public GameObject Display;
    public GameObject ToggleCheckmark;
    public GameObject ToggleIo;
    public GameObject InventoryListButton;
    public Text Ergebnis;
    public Text Ergebnis2;

    public void Update(){

    if(Ergebnis.text == "0196" & Ergebnis2.text == "191.080"){
        Debug.Log("Squawk and Frequency Code correct");
        Invoke("DelayActive", 1.5f);
        ToggleCheckmark.SetActive(true);
        ToggleIo.SetActive(false);
        }
    }

    public void DelayActive(){
        Display.SetActive(false);
        InventoryListButton.SetActive(true);
    }
}
