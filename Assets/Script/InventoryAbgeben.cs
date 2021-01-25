using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAbgeben : MonoBehaviour
{
    
    public GameObject Toggle1;
    public GameObject Toggle2;
    public GameObject Toggle3;
    public GameObject Toggle4;
    public GameObject Toggle5;
    public GameObject Toggle6;
    public GameObject Io;

    // Update is called once per frame
    public void Update()
    {
    
     if(Toggle1.activeSelf && Toggle2.activeSelf && Toggle3.activeSelf && Toggle4.activeSelf && Toggle5.activeSelf && Toggle6.activeSelf){
         Debug.Log("positive");
         Io.SetActive(true);
     }
    }
}
