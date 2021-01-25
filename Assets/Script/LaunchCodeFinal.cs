using System.Net.Mime;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LaunchCodeFinal : MonoBehaviour
{

    public Text InputFieldErgebnis;
    public GameObject Correct;
    public GameObject InputField;
    public GameObject Button;
    public GameObject FinalDisplay;
    public GameObject ThisDisplay;
    public Text Dialog;

    // Update is called once per frame
    void Update()
    {
        if(InputFieldErgebnis.text == "20"){
        Debug.Log("approved");
        Correct.SetActive(true);
        InputField.SetActive(false);
        Button.SetActive(false);
        Invoke("DelayActive", 2.5f);
        Dialog.text = " ";
        Invoke("ReloadScenefunction", 8f);
        }
    }

    public void DelayActive(){
        FinalDisplay.SetActive(true);
        ThisDisplay.SetActive(false);
    }

    public void ReloadScenefunction(){
        SceneManager.LoadScene("ReloadedScene");    
    }
}
