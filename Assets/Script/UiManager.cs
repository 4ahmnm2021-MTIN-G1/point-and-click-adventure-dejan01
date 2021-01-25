using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

public InteractabelObject activeIO;

    public void CollectItem()
    {
        Debug.Log("CollectItem FKT ist aufgerufen");
        activeIO.img.sprite = activeIO.spriteObject;
    }

    public void Inspect(){
        activeIO.Communication.SetActive(true);
    }

    public void InvokeReload(){
        Invoke("ReloadScenefunction", 4f);
        Debug.Log("Invoke");
    }

    public void ReloadScenefunction(){
        SceneManager.LoadScene("ReloadedScene");    
    }

}
