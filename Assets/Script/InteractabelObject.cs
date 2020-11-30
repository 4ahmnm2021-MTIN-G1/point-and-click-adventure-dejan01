using System.ComponentModel;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractabelObject : MonoBehaviour
{
    public GameObject commandMenu;
    public UiManager uiManager;
    public Transform reposition;
    public Text Dialogfenster;
    public string inspectText;
    public SpriteRenderer sr;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        commandMenu.active = true;
        commandMenu.transform.position = reposition.position;
        uiManager.activeIO = this;
        
        //Dialogfenster.text = inspectText;

    }
}
