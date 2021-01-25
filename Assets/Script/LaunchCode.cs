using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchCode : MonoBehaviour
{
    public GameObject Display;
    public GameObject Toggle;
    public GameObject InventoryListButton;
    public Text Ergebnis;

    public void Update(){

    if(Ergebnis.text == "20" ){
        Debug.Log("zwanzig");
        Invoke("DelayActive", 1.5f);
        Toggle.SetActive(true);
    }

    }

    public void DelayActive(){
        Display.SetActive(false);
        InventoryListButton.SetActive(true);
    }
}
